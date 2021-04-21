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
    public partial class FrmRegistarProveedores : Form
    {
        ClsValidarCampos VC = new ClsValidarCampos();
        ClsEmpresa E = new ClsEmpresa();
        public FrmRegistarProveedores()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtNit, "Nit del Proveedor");
            this.toolTip1.SetToolTip(this.txtRacSoc, "Razón Social del Proveedor");
            this.toolTip1.SetToolTip(this.txtDireccion, "Dirección del Proveedor");
            this.toolTip1.SetToolTip(this.txtTelefono, "Teléfono del Proveedor");
            this.toolTip1.SetToolTip(this.btnAceptar, "Ingresar Registro");
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar Registro");
        }

        private void Limpiar()
        {
            txtNit.Text = "";
            txtRacSoc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtNit.Focus();
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
            if (txtNit.Text.Trim() != "")
            {
                if (txtRacSoc.Text.Trim() != "")
                {
                    if (txtDireccion.Text.Trim() != "")
                    {
                        if (txtTelefono.Text.Trim() != "")
                        {
                            if (Program.Evento == 0)
                            {
                                E.Identificacion = txtNit.Text;
                                E.Nombre = txtRacSoc.Text;
                                E.Direccion = txtDireccion.Text;
                                E.Telefono = Convert.ToInt64(txtTelefono.Text);
                                MessageBox.Show(E.RegistrarProveedor(), "  | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                this.Close();
                            }
                            else
                            {
                                E.Identificacion = txtNit.Text;
                                E.Nombre = txtRacSoc.Text;
                                E.Direccion = txtDireccion.Text;
                                E.Telefono = Convert.ToInt64(txtTelefono.Text);
                                MessageBox.Show(E.ActualizarProveedor(), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por Favor Ingrese N° de Teléfono o Proveedor.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTelefono.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Ingrese Dirección del Proveedor.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDireccion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese el nombre del Proveedor.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRacSoc.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese N° de identificación del Proveedor.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNit.Focus();
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

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.nit(sender,e);
        }

        private void txtRacSoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.numerosyletras(sender,e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.numerosyletras(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloNumeros(sender,e);
        }

        private void txtNit_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtRacSoc_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtDireccion_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtTelefono_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
        //Fin boton cancelar
    }

}
