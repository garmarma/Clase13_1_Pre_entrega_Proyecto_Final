using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud_Entregable.Models;
using Crud_Entregable.Repository;

namespace Crud_Entregable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            List<Producto> productos = Metodos.ObtenerProductos();
            dataGridView.DataSource = productos;
        }

        private void ProductosVendidos_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> productosVendidos = Metodos.ObtenerProductosVendidos();
            dataGridView.DataSource = productosVendidos;
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios =Metodos.ObtenerUsuarios();
            dataGridView.DataSource = usuarios;
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            List<Venta> ventas = Metodos.ObtenerVentas();
            dataGridView.DataSource = ventas;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            Usuario usuario = Metodos.IniciarSesion(nombreUsuario, contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Correcto");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
