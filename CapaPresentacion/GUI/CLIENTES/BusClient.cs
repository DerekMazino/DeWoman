using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.CLIENTES
{
    public partial class BusClient : Form
    {
        public BusClient()
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
            Clientes cliente = new Clientes();
            cliente.ShowDialog();
        }
        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton agregar
        //Boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Código del boton       
        }
        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton editar
        //Boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Código del boton
        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        // Fin boton eliminar
    }
}
