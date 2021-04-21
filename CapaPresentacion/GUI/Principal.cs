using ProyectoInte.GUI;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoInte.GUI.COMPRAS;
using ProyectoInte.GUI.CLIENTES;

namespace ProyectoInte
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 ancho = (desktopSize.Width - panel3.Width) / 2;
            panel3.Location = new Point(ancho, panel3.Location.Y);
            lblfecha.Text = DateTime.Now.ToShortDateString();
            //sesionU(u);
            Size tamanoPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 xequi = (tamanoPantalla.Width - 92) ;
            btnMini.Location = new Point(xequi, btnMini.Location.Y);
            Int32 xequis = (tamanoPantalla.Width - 52) ;
            pictureBox2.Location = new Point(xequis, pictureBox2.Location.Y);
        }
        //Boton minimizar

        private void btnMini_MouseHover(object sender, EventArgs e)
        {
            btnMini.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
// Fin boton minimizar
        //Boton Salir
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Salir.", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
//Fin boton salir

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        //Boton Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.ShowDialog();
        }
        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackgroundImageLayout = ImageLayout.Zoom;            
        }

        //Fin boton usuarios
        //Boton Compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras com = new Compras();
            com.ShowDialog();
        }
        private void btnCompras_MouseHover(object sender, EventArgs e)
        {
            btnCompras.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //Fin boton Compras
        //////////Boton Ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.ShowDialog();
        }
        private void btnVentas_MouseHover(object sender, EventArgs e)
        {
            btnVentas.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //Fin Boton ventas
//////////Boton Proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores prove = new Proveedores();
            prove.ShowDialog();
        }
        private void btnProveedores_MouseHover(object sender, EventArgs e)
        {
            btnProveedores.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //Fin boton proveedores
/////////Boton Facturas
        private void btnFacturas_Click(object sender, EventArgs e)
        {

        }
        private void btnFacturas_MouseHover(object sender, EventArgs e)
        {
            btnFacturas.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnFacturas_MouseLeave(object sender, EventArgs e)
        {
            btnFacturas.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //Fin boton facturas
        //Boton Inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inven = new Inventario();
            inven.ShowDialog();
        }
        private void btnInventario_MouseHover(object sender, EventArgs e)
        {
            btnInventario.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            btnInventario.BackgroundImageLayout = ImageLayout.Zoom;
        }

//Fin boton inventario
        //Boton Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            BusClient clie = new BusClient();
            clie.ShowDialog();
        }
        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            btnClientes.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            lbluser.Text = "Usuario: " + Program.nombreUsu + "  *Tipo Usuario: " + Program.tipoUsuario;
        }

        /*      private void pictureBox3_Click(object sender, EventArgs e)
              {
                  Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
                  Int32 ancho = (this.Width - pictureBox3.Width) / 2;
                  Int32 largo = (this.Height - pictureBox3.Height) / 2;
                  pictureBox3.Location = new Point(ancho, largo);
              }*/
        //Fin boton clientes
    }
}