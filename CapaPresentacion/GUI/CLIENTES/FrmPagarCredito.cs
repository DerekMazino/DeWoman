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
namespace ProyectoInte.GUI.CLIENTES
{
    public partial class FrmPagarCredito : Form
    {
        
        public FrmPagarCredito()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAcep, "ACeptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAbono.Text) >0)
            {
                if (Convert.ToInt32(txtAbono.Text) < Convert.ToInt32(txtSaldo.Text))
                {
                    ClsCredito C = new ClsCredito();
                    C.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    C.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    C.MontoPagar = Convert.ToInt32(txtAbono.Text);
                    MessageBox.Show(C.RegistrarAbonoCredito(), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                else
                {
                    MessageBox.Show("El monto no puede ser superior a la deuda.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por Favor ingrese el monto a abonar", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.soloNumeros(sender,e);
            VC.BloquearTeclaControl(sender, e);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAbono_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
    }
}
