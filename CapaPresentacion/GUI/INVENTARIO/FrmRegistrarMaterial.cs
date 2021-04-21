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
    public partial class FrmRegistrarMaterial : Form
    {
        ClsValidarCampos VC = new ClsValidarCampos();
        ClsElemento E = new ClsElemento();
        public FrmRegistrarMaterial()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAcep, "ACeptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");
        }
        private void Limpiar()
        {
            txtMat.Text = "";
            txtId.Clear();
            txtMat.Focus();
        }
        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Boton Aceptar
        private void btnAcep_Click(object sender, EventArgs e)
        {
            if (txtMat.Text.Trim() != "")
            {
                if (Program.Evento == 0)
                {
                    E.Nombre = txtMat.Text;
                    MessageBox.Show(E.RegistrarMaterial(), "  | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    this.Close();
                }
                else
                {
                    E.Nombre = txtMat.Text;
                    MessageBox.Show(E.ActualizarMaterial(txtId.Text), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese el Material", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMat.Focus();
            }
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
            Close();
        }

        private void txtMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.numerosyletras(sender,e);
        }
        //Fin boton cancelar
    }
}

