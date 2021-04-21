using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI
{
    public partial class Proveedores : Form
    {
        public Proveedores()
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
        //Boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Código de lo que hace el botón
        }

        //Fin boton agregar
        //Boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Código del boton       
        }
        //Fin boton editar

        //Boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Código del boton
        }
        // Fin boton eliminar
        // Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Código del boton
        }
        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton aceptar
        //Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Código del boton
        }
        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton cancelar
    }

}
