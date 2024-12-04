namespace Ejercicio11.Windows
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            tsEditar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsCerrar = new ToolStripButton();
            panel1 = new Panel();
            txtProducto = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colDescripción = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colCategoría = new DataGridViewTextBoxColumn();
            tsFiltrar = new ToolStripSplitButton();
            ordenarPorMayorToolStripMenuItem = new ToolStripMenuItem();
            ordenarPorMenorToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, toolStripButton4, tsEditar, toolStripSeparator2, tsbActualizar, tsFiltrar, toolStripSeparator1, tsCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.add_file_48px;
            btnNuevo.ImageScaling = ToolStripItemImageScaling.None;
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(52, 67);
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNuevo.Click += tsbNuevo_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.delete_file_48px;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(52, 67);
            toolStripButton4.Text = "Borrar";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton4.Click += tsbBorrar_Click;
            // 
            // tsEditar
            // 
            tsEditar.Image = Properties.Resources.edit_file_48px;
            tsEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsEditar.ImageTransparentColor = Color.Magenta;
            tsEditar.Name = "tsEditar";
            tsEditar.Size = new Size(52, 67);
            tsEditar.Text = "Editar";
            tsEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsEditar.ToolTipText = "tsEditar";
            tsEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 67);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // tsCerrar
            // 
            tsCerrar.Image = Properties.Resources.exit_48px;
            tsCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsCerrar.ImageTransparentColor = Color.Magenta;
            tsCerrar.Name = "tsCerrar";
            tsCerrar.Size = new Size(52, 67);
            tsCerrar.Text = "Cerrar";
            tsCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsCerrar.ToolTipText = "tsCerrar";
            tsCerrar.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtProducto);
            panel1.Location = new Point(21, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 361);
            panel1.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(73, 8);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 73);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Producto:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colPrecio, colDescripción, colStock, colCategoría });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 70);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(800, 380);
            dgvDatos.TabIndex = 3;
            // 
            // colClave
            // 
            colClave.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colClave.HeaderText = "Clave";
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            colClave.Width = 61;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 65;
            // 
            // colDescripción
            // 
            colDescripción.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripción.HeaderText = "Descripción";
            colDescripción.Name = "colDescripción";
            colDescripción.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 61;
            // 
            // colCategoría
            // 
            colCategoría.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCategoría.HeaderText = "Categoría";
            colCategoría.Name = "colCategoría";
            colCategoría.ReadOnly = true;
            colCategoría.Width = 83;
            // 
            // tsFiltrar
            // 
            tsFiltrar.DropDownItems.AddRange(new ToolStripItem[] { ordenarPorMayorToolStripMenuItem, ordenarPorMenorToolStripMenuItem });
            tsFiltrar.Image = Properties.Resources.filled_filter_48px;
            tsFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsFiltrar.ImageTransparentColor = Color.Magenta;
            tsFiltrar.Name = "tsFiltrar";
            tsFiltrar.Size = new Size(64, 67);
            tsFiltrar.Text = "Filtrar";
            tsFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsFiltrar.ToolTipText = "tsFiltrar";
            // 
            // ordenarPorMayorToolStripMenuItem
            // 
            ordenarPorMayorToolStripMenuItem.Image = Properties.Resources.numerical_sorting_21_48px;
            ordenarPorMayorToolStripMenuItem.Name = "ordenarPorMayorToolStripMenuItem";
            ordenarPorMayorToolStripMenuItem.Size = new Size(180, 22);
            ordenarPorMayorToolStripMenuItem.Text = "Ordenar por mayor";
            ordenarPorMayorToolStripMenuItem.Click += área09ToolStripMenuItem_Click;
            // 
            // ordenarPorMenorToolStripMenuItem
            // 
            ordenarPorMenorToolStripMenuItem.Image = Properties.Resources.numerical_sorting_12_48px;
            ordenarPorMenorToolStripMenuItem.Name = "ordenarPorMenorToolStripMenuItem";
            ordenarPorMenorToolStripMenuItem.Size = new Size(180, 22);
            ordenarPorMenorToolStripMenuItem.Text = "Ordenar por menor";
            ordenarPorMenorToolStripMenuItem.Click += área90ToolStripMenuItem_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(578, 364);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton toolStripButton4;
        private ToolStripButton tsEditar;
        private ToolStripButton tsCerrar;
        private Panel panel1;
        private Label label1;
        private TextBox txtProducto;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colDescripción;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colCategoría;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton tsFiltrar;
        private ToolStripMenuItem ordenarPorMayorToolStripMenuItem;
        private ToolStripMenuItem ordenarPorMenorToolStripMenuItem;
    }
}