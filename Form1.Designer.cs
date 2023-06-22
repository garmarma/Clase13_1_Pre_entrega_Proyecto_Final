namespace Crud_Entregable
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.Productos = new System.Windows.Forms.Button();
            this.ProductosVendidos = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(28, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(642, 278);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(150, 364);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(270, 364);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 23);
            this.txtContrasena.TabIndex = 4;
            // 
            // Productos
            // 
            this.Productos.Location = new System.Drawing.Point(676, 33);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(112, 23);
            this.Productos.TabIndex = 5;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // ProductosVendidos
            // 
            this.ProductosVendidos.Location = new System.Drawing.Point(676, 62);
            this.ProductosVendidos.Name = "ProductosVendidos";
            this.ProductosVendidos.Size = new System.Drawing.Size(111, 23);
            this.ProductosVendidos.TabIndex = 6;
            this.ProductosVendidos.Text = "Productos Vendidos";
            this.ProductosVendidos.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.Usuarios.Location = new System.Drawing.Point(676, 91);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(112, 23);
            this.Usuarios.TabIndex = 7;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.Ventas.Location = new System.Drawing.Point(676, 120);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(111, 23);
            this.Ventas.TabIndex = 8;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Location = new System.Drawing.Point(209, 399);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(130, 23);
            this.IniciarSesion.TabIndex = 9;
            this.IniciarSesion.Text = "Iniciar Sesion";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.ProductosVendidos);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button Productos;
        private Button ProductosVendidos;
        private Button Usuarios;
        private Button Ventas;
        private Button IniciarSesion;
    }
}