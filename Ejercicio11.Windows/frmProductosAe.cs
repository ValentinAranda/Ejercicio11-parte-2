using Ejercicio11.entidades;
using Ejercicio11.Progl.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11.Windows
{
    public partial class frmProductosAe : Form
    {
        private RepositorioDeProductos? repo;
        private Producto? producto;
        private List<Producto> ListaProductos;
        private RepositorioDeProductos repositorioDeProductos;

        public frmProductosAe()
        {
            InitializeComponent();
            repo = new RepositorioDeProductos();
        }

        public frmProductosAe(RepositorioDeProductos repositorioDeProductos)
        {
            this.repositorioDeProductos = repositorioDeProductos;
        }

        public Producto? GetProductos()
        {
            return producto;
        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Producto();
                }
                producto.Clave = int.Parse(txtClave.Text);
                producto.Nombre = (txtNombre.Text);
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Descripcion = txtDescripcion.Text;
                producto.Stock = int.Parse(txtStock.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!ValidaClave(txtClave.Text))
            {
                valido = true;
                errorProvider1.SetError(txtClave, "Clave única no valida.");
            }
            if (String.IsNullOrEmpty(txtClave.Text))
            {
                valido = true;
                errorProvider1.SetError(txtClave, "Clave única no ha sido ingresada.");
            }
            if (String.IsNullOrEmpty(lbCategoria.Text))
            {
                valido = true;
                errorProvider1.SetError(lbCategoria, "Categoría no ha sido ingresada.");
            }
            if (String.IsNullOrEmpty(lbNombre.Text))
            {
                valido = true;
                errorProvider1.SetError(lbNombre, "Nombre del producto no ha sido ingresado.");
            }
            return valido;
        }

        private bool ValidaClave(string text)
        {
            bool valido = true;
            if (!int.TryParse(txtClave.Text, out int Clave) ||
                Clave <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtClave, "Clave mal ingresado");
            }
            return valido;
        }

        private void frmProductosAe_Load(object sender, EventArgs e)
        {
            GenerarDatosComboCategoria(ref cboxCategoria);
        }

        private static void GenerarDatosComboCategoria(ref ComboBox cboxCategoria)
        {
            var categoria = Enum.GetValues(typeof(Categoria));
            cboxCategoria.DataSource = categoria;
            cboxCategoria.SelectedIndex = 0;
            cboxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void labClave_Click(object sender, EventArgs e)
        {

        }
    }
}
