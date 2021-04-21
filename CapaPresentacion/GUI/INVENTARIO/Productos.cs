using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
namespace ProyectoInte.GUI.INVENTARIO
{
    public partial class Productos : Form
    {
        ClsValidarCampos clsVC = new ClsValidarCampos();
        public Productos()
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
            btnAcep.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAcep.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton aceptar
        //Boton Cancelar
        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCan.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCan.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {

        }

        private void txtProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.caracteresEspeciales(sender,e);
            clsVC.soloLetras(sender,e);
        }

        private void txtPrecio_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender, e);
        }

        private void txtRefe_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender,e);
        }

        private void Productos_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.soloNumeros(sender, e);
            clsVC.caracteresEspeciales(sender,e);
        }
        //Fin boton cancelar

    }
}
