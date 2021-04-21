using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoInte.GUI;
using ProyectoInte.GUI.INVENTARIO;


namespace ProyectoInte.GUI
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        // Fin Boton cerrar

        // Boton Aceptar
        private void btnAcep_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnProduc.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnProduc.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton aceptar
        //Boton Cancelar
        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnMate.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnMate.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton cancelar
        private void btnMate_Click(object sender, EventArgs e)
        {
            Materiales mate = new Materiales();
            mate.ShowDialog();
        }
        private void btnProduc_Click(object sender, EventArgs e)
        {
            BuscProducto produc = new BuscProducto();
            produc.ShowDialog();
        }
    }
}
