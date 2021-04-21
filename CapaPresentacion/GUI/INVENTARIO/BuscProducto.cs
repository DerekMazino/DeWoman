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
    public partial class BuscProducto : Form
    {
        ClsValidarCampos ClsCV = new ClsValidarCampos();
        public BuscProducto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        //Boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Código de lo que hace el botón
        }
        private void btnAgregar_MouseHover(object sender, EventArgs e)
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

        private void txtBuscarPro_MouseDown(object sender, MouseEventArgs e)
        {
            ClsCV.inhabilitarClicDerecho(sender,e);
        }

        private void txtBuscarPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsCV.caracteresEspeciales(sender, e);
            ClsCV.soloLetras(sender, e);
        }
        // Fin boton eliminar
    }
}
