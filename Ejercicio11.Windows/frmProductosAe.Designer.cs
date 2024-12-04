namespace Ejercicio11.Windows
{
    partial class frmProductosAe
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
            components = new System.ComponentModel.Container();
            labClave = new Label();
            txtClave = new TextBox();
            lbCategoria = new Label();
            boxProducto = new GroupBox();
            txtStock = new TextBox();
            lbStock = new Label();
            txtDescripcion = new TextBox();
            lbDescripcion = new Label();
            txtPrecio = new TextBox();
            lbPrecio = new Label();
            txtNombre = new TextBox();
            lbNombre = new Label();
            btnOK = new Button();
            btnCancelar = new Button();
            cboxCategoria = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            boxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labClave
            // 
            labClave.AutoSize = true;
            labClave.Location = new Point(29, 36);
            labClave.Name = "labClave";
            labClave.Size = new Size(68, 15);
            labClave.TabIndex = 0;
            labClave.Text = "Clave única";
            labClave.Click += labClave_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(103, 36);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 1;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(226, 36);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 2;
            lbCategoria.Text = "Categoría";
            // 
            // boxProducto
            // 
            boxProducto.Controls.Add(txtStock);
            boxProducto.Controls.Add(lbStock);
            boxProducto.Controls.Add(txtDescripcion);
            boxProducto.Controls.Add(lbDescripcion);
            boxProducto.Controls.Add(txtPrecio);
            boxProducto.Controls.Add(lbPrecio);
            boxProducto.Controls.Add(txtNombre);
            boxProducto.Controls.Add(lbNombre);
            boxProducto.Location = new Point(29, 65);
            boxProducto.Name = "boxProducto";
            boxProducto.Size = new Size(361, 150);
            boxProducto.TabIndex = 4;
            boxProducto.TabStop = false;
            boxProducto.Text = "Producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(67, 113);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(279, 23);
            txtStock.TabIndex = 1;
            txtStock.TextChanged += textBox1_TextChanged;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(10, 116);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(36, 15);
            lbStock.TabIndex = 0;
            lbStock.Text = "Stock";
            lbStock.Click += lbNombre_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(67, 84);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(279, 23);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(10, 87);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(49, 15);
            lbDescripcion.TabIndex = 0;
            lbDescripcion.Text = "Descrip.";
            lbDescripcion.Click += lbNombre_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(67, 55);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(279, 23);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextChanged += textBox1_TextChanged;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(10, 58);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(40, 15);
            lbPrecio.TabIndex = 0;
            lbPrecio.Text = "Precio";
            lbPrecio.Click += lbNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(10, 29);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            lbNombre.Click += lbNombre_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ControlDark;
            btnOK.Location = new Point(426, 75);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(131, 63);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDark;
            btnCancelar.Location = new Point(426, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 63);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboxCategoria
            // 
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Location = new Point(290, 36);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(121, 23);
            cboxCategoria.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProductosAe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 325);
            Controls.Add(cboxCategoria);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(boxProducto);
            Controls.Add(lbCategoria);
            Controls.Add(txtClave);
            Controls.Add(labClave);
            MaximumSize = new Size(578, 364);
            MinimumSize = new Size(578, 364);
            Name = "frmProductosAe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductosAe";
            Load += frmProductosAe_Load;
            boxProducto.ResumeLayout(false);
            boxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labClave;
        private TextBox txtClave;
        private Label lbCategoria;
        private GroupBox boxProducto;
        private TextBox txtNombre;
        private Label lbNombre;
        private TextBox txtStock;
        private Label lbStock;
        private TextBox txtDescripcion;
        private Label lbDescripcion;
        private TextBox txtPrecio;
        private Label lbPrecio;
        private Button btnOK;
        private Button btnCancelar;
        private ComboBox cboxCategoria;
        private ErrorProvider errorProvider1;
    }
}