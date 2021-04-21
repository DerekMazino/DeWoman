using ProyectoInte.GUI.CLIENTES;
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
namespace ProyectoInte.GUI
{
    public partial class FrmRegistrarClientes : Form
    {
        ClsValidarCampos VC = new ClsValidarCampos();
        ClsCliente C = new ClsCliente();
        public FrmRegistrarClientes()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAceptar, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
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
        private void Limpiar()
        {
            txtCedula.Text = "";
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCedula.Focus();
        }
        // Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Trim() != "")
            {
                if (txtNombre.Text.Trim() != "")
                {
                    if (txtDireccion.Text.Trim() != "")
                    {
                        if (txtTelefono.Text.Trim() != "")
                        {
                            if (Program.Evento == 0)
                            {
                                C.Identificacion = txtCedula.Text;
                                C.Apellido = txtApellido.Text;
                                C.Nombre = txtNombre.Text;
                                C.Empresa = txtEmpresa.Text;
                                C.Direccion = txtDireccion.Text;
                                C.Telefono = Convert.ToInt64(txtTelefono.Text);
                                C.Saldo = 0;
                                MessageBox.Show(C.RegistrarCliente(), "  | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                this.Close();
                            }
                            else
                            {
                                C.Identificacion = txtCedula.Text;
                                C.Apellido = txtApellido.Text;
                                C.Nombre = txtNombre.Text;
                                C.Empresa = txtEmpresa.Text;
                                C.Direccion = txtDireccion.Text;
                                C.Telefono = Convert.ToInt64(txtTelefono.Text);
                                MessageBox.Show(C.ActualizarCliente(), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por Favor Ingrese N° de Teléfono o Celular.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTelefono.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Ingrese Dirección del Cliente.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDireccion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese Nombre(s) del Cliente.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                }

            }
            else
            {
                MessageBox.Show("Por Favor Ingrese N° de Cedula del Cliente.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCedula.Focus();
            }
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
            this.Close();
        }
        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.nit(sender, e);
            VC.BloquearTeclaControl(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloLetras(sender, e);
            VC.BloquearTeclaControl(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloLetras(sender,e);
            VC.BloquearTeclaControl(sender, e);
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloLetras(sender, e);
            VC.BloquearTeclaControl(sender, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.BloquearTeclaControl(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.BloquearTeclaControl(sender, e);
        }

        private void txtCedula_MouseDown(object sender, MouseEventArgs e)
        {
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtApellido_MouseDown(object sender, MouseEventArgs e)
        {
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtNombre_MouseDown(object sender, MouseEventArgs e)
        {
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtEmpresa_MouseDown(object sender, MouseEventArgs e)
        {
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtDireccion_MouseDown(object sender, MouseEventArgs e)
        {
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtTelefono_MouseDown(object sender, MouseEventArgs e)
        {
            VC.inhabilitarClicDerecho(sender, e);
        }
        //Fin boton cancelar
    }
}
