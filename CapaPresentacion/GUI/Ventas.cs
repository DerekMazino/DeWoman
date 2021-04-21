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
    public partial class Ventas : Form
    {
        public Ventas()
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
        private void btnAgg_Click(object sender, EventArgs e)
        {
            //Código de lo que hace el botón
        }
        private void btnAgg_MouseHover(object sender, EventArgs e)
        {
            btnAgg.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgg.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton agregar
        //Boton editar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Código del boton       
        }
        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton editar
        //Boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Codigo 
        }
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBusc.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBusc.BackgroundImageLayout = ImageLayout.Zoom;
        }
        // Fin boton Buscar
        //Boton eliminar
        private void btnElim_Click(object sender, EventArgs e)
        {
            //Código del boton
        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnElim.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnElim.BackgroundImageLayout = ImageLayout.Zoom;
        }
        // Fin boton eliminar
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
        //Fin boton cancelar
    }
}
