using Ejercicio11.entidades;
using Ejercicio11.Progl.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11.Windows
{
    public partial class frmProductos : Form
    {
        private RepositorioDeProductos? repo;
        private List<Producto> listaProductos;
        private int cantidadRegistros;
        public frmProductos()
        {
            InitializeComponent();
            repo = new RepositorioDeProductos();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmProductosAe frm = new frmProductosAe(repo!) { Text = "Nuevo producto:" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Producto? producto = frm.GetProductos();
            try
            {
                if (repo!.Existe(producto!))
                {
                    repo.Agregar(producto!);
                    DataGridViewRow r = ConstruirFila(dgvDatos);
                    SetearFila(r, producto!);
                    AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("¡¡¡Registro existente!!!", "¡¡¡Error!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡¡¡Algún error!!!", "¡¡¡Error!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Producto producto = (Producto)r.Tag!;
            DialogResult dr = MessageBox.Show("¿Desea borrar el producto?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            try
            {
                repo!.EliminarProducto(producto);
                EliminarFila(r, dgvDatos);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Producto? producto = (Producto)r.Tag!;
            frmProductosAe frm = new frmProductosAe(repo!) { Text = "Editar punto" };
            frm.SetProducto(producto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                producto = frm.GetProductos();
                SetearFila(r, producto!);
                MessageBox.Show("Registro editado", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("¡¡¡Algún error!!!", "¡Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            listaProductos = repo!.ObtenerProducto();
            MostrarDatosEnGrilla();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repo!.GuardarDatos();
            MessageBox.Show("Fin del Programa", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void área09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaProductos = repo.OrdenarAsc();
            MostrarDatosEnGrilla();
        }

        private void área90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaProductos = repo.OrdenarDesc();
            MostrarDatosEnGrilla();

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cantidadRegistros = repo!.GetHashCode();
            if (cantidadRegistros > 0)
            {
                listaProductos = repo.ObtenerProducto();
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            LimpiarGrilla(dgvDatos);
            foreach (var item in listaProductos)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r, dgvDatos);
            }
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[colClave.Index].Value = producto.Clave;
            r.Cells[colNombre.Index].Value = producto.Nombre;
            r.Cells[colPrecio.Index].Value = producto.Precio;
            r.Cells[colStock.Index].Value = producto.Stock;
            r.Cells[colDescripción.Index].Value = producto.Descripcion;
            r.Cells[colCategoría.Index].Value = producto.Categoria;
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        private void EliminarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        public void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        private DataGridViewRow ConstruirFila(DataGridView dgvDatos)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }
    }
}
