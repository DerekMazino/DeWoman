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
    public partial class FrmRegistrarCategoria : Form
    {
        ClsValidarCampos vc = new ClsValidarCampos();
        ClsCategoria C = new ClsCategoria();
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAcep, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            vc.numerosyletras(sender,e);
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Trim() != "")
            {
                    C.Categoria = txtCategoria.Text;
                    MessageBox.Show(C.RegistrarCategoria(), "  | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();                
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese la categoria", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategoria.Focus();
            }

        }
        private void btnAcep_MouseHover(object sender, EventArgs e)
        {
            btnAcep.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnAcep_MouseLeave(object sender, EventArgs e)
        {
            btnAcep.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnCan_MouseHover(object sender, EventArgs e)
        {
            btnCan.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCan_MouseLeave(object sender, EventArgs e)
        {
            btnCan.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
