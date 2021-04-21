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
    public partial class FrmRegistrarProducto : Form
    {
        ClsValidarCampos clsVC = new ClsValidarCampos();
        ClsProducto P = new ClsProducto();
        public FrmRegistrarProducto()
        {
            InitializeComponent();
            cargarCBX();
            this.toolTip1.SetToolTip(this.btnAcep, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");
        }
        private void cargarCBX()
        {
            ClsCategoria cc = new ClsCategoria();
            cbxCategoria.DataSource = cc.ListarCategoria();
            cbxCategoria.DisplayMember = "Cat_Nom";
            cbxCategoria.ValueMember = "Id_Cat";
        }
        private void Limpiar()
        {
            txtRefe.Text = "";
            txtPrecio.Clear();
            txtRefe.Focus();
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
            if (pictureBox1.Image != null)
            {
                if (txtRefe.Text.Trim() != "")
                {
                    if (txtPrecio.Text.Trim() != "")
                    {
                        if (Program.Evento == 1)
                        {
                            P.Nombre = txtRefe.Text;
                            P.Precio = Convert.ToInt32(txtPrecio.Text);
                            P.Categoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
                            P.Stock = 0;
                            MessageBox.Show(P.RegistrarProducto(ClsConvertImage.ImageToByteArray(pictureBox1.Image)), "  | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            Program.Evento = 0;
                            this.Close();
                        }
                        else
                        {
                            P.Nombre = txtRefe.Text;
                            P.Precio = Convert.ToInt32(txtPrecio.Text);
                            P.Categoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
                            MessageBox.Show(P.ActualizarProducto(ClsConvertImage.ImageToByteArray(pictureBox1.Image)), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            Program.Evento = 0;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Favor el precio del producto.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPrecio.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor ingrese la referencia del producto.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRefe.Focus();
                }
            }
            else {
                MessageBox.Show("Por Favor asigne una imagen al producto.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnAgg_Ima.Focus();
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

        private void txtProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
        }

        private void btnAgg_Ima_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            cargarCBX();
        }

        private void FrmRegistrarProducto_Activated(object sender, EventArgs e)
        {
            cargarCBX();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria rc = new FrmRegistrarCategoria();
            rc.ShowDialog();
        }
        //Fin boton cancelar

    }
}
