using ProyectoInte.GUI;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoInte.GUI.COMPRAS;
using ProyectoInte.GUI.CLIENTES;
using ProyectoInte.GUI.PROVEEDORES;
using ProyectoInte.GUI.ListadoDeReportes;

namespace ProyectoInte
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnMini, "Minimizar");
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar Sesión");
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
            btnSalir.Location = new Point(xequis, btnSalir.Location.Y);
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
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Salir.", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
               Login Login = new Login();
                Login.Show();
                Close();
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
            FrmRegistrarUsuario usu = new FrmRegistrarUsuario();
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
            FrmRegistrarVenta ven = new FrmRegistrarVenta();
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
            FrmListadoProveedores bp = new FrmListadoProveedores();
            bp.ShowDialog();
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
            MenuReportes Mr = new MenuReportes();
            Mr.ShowDialog();
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
            FrmInventario inven = new FrmInventario();
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
            FrmListadoCliente clie = new FrmListadoCliente();
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
            lbluser.Text = "Usuario: " + Program.nombreUsu + " , Cargo: " + Program.tipoUsuario;
            Program.Evento = 999;
            Program.EventoCompraVentaFabricacion = 0;
            if (Program.idCargo == 2)
            {
                btnUsuarios.Visible = false;
                btnClientes.Visible = false;
            }
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        //Fin boton clientes
    }
}