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
    public partial class FrmRegistrarUsuario : Form
    {
        ClsUsuario clsU = new ClsUsuario();
        ClsValidarCampos clsVC = new ClsValidarCampos();
        private int oper;
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            IniciarC();
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar usuario");
            this.toolTip1.SetToolTip(this.btnEditar, "Editar usuario");
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar usuario");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar usuario");
            this.toolTip1.SetToolTip(this.btnAceptar, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
        }
        void cargarCBX()
        {
            cbxCargo.DataSource = clsU.ListarCargo();
            cbxCargo.DisplayMember = "Nom_Car";
            cbxCargo.ValueMember = "Id_Car";
        }
        void limpiarCampos()
        {
            txtNom.Clear();
            txtApe.Clear();
            txtCedula.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
        }
        void IniciarC()
        {
            txtNom.Enabled = false;
            txtApe.Enabled = false;
            txtCedula.Enabled = false;
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            cbxCargo.Enabled = false;
            cargarCBX();
            limpiarCampos();
            btnAceptar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            oper = 0;
        }
        void Habilitar()
        {
            txtNom.Enabled = true;
            txtApe.Enabled = true;
            txtCedula.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            cbxCargo.Enabled = true;
            cargarCBX();
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
        }
    //Fin boton editar
    //Boton buscar
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
        }
    // Fin boton Buscar
    //Boton eliminar
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
        }
    // Fin boton eliminar
    // Boton Aceptar
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
        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case 1:
                    InsertarUsuario();
                    break;
                case 2:
                    ModificarUsuario();
                    break;
                /*case 3:
                    EliminarUsuario();
                    break;*/
                case 4:
                    ConsultarUsuario();
                    break;
                default:
                    MessageBox.Show("Algo salio mal", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    break;
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargarCBX();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilitar();
            oper = 1;
            btnAgregar.Enabled = false;
            btnBuscar.Enabled = false;
        }
        //Fin boton cancelar
        void InsertarUsuario()
        {
            String msj = "";
            if (txtNom.Text == "" || txtApe.Text == "" || txtCedula.Text == "" || txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Error, debe llenar todos los campos", "|  AVISO ~ ShoeSoft |");
                limpiarCampos();
            }
            else
            {
                try
                {
                    clsU.Identificacion = txtCedula.Text;
                    clsU.Nombre = txtNom.Text;
                    clsU.Apellido = txtApe.Text;
                    clsU.Nusuario = txtUsuario.Text;
                    clsU.Contraseña = txtPassword.Text;
                    clsU.Cargo = Convert.ToInt32(cbxCargo.SelectedValue);
                    msj = clsU.RegistrarUsuario();
                    MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                    IniciarC();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "|  AVISO ~ ShoeSoft |");
                }
            }
        }
        void ModificarUsuario()
        {
            String msj = "";
            if (txtNom.Text == "" || txtApe.Text == "" || txtCedula.Text == "" || txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Error, debe llenar todos los campos", "|  AVISO ~ ShoeSoft |");
            }
            else
            {
                try
                {
                    clsU.Identificacion = txtCedula.Text;
                    clsU.Nombre = txtNom.Text;
                    clsU.Apellido = txtApe.Text;
                    clsU.Nusuario = txtUsuario.Text;
                    clsU.Contraseña = txtPassword.Text;
                    clsU.Cargo = Convert.ToInt32(cbxCargo.SelectedValue);
                    msj = clsU.ModificarUsuario();
                    MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                    IniciarC();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "|  AVISO ~ ShoeSoft |");
                }
            }
        }
        void EliminarUsuario()
        {
            String msj = "";
            try
            {
                msj = clsU.eliminarUsuario(txtCedula.Text);
                MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                IniciarC();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "|  AVISO ~ ShoeSoft |");
            }
        }
        void ConsultarUsuario()
        {
            DataRow row;
            DataTable dt = new DataTable();
            dt = clsU.cargarUsuario(txtCedula.Text);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                txtCedula.Text = row[0].ToString();
                txtNom.Text = row[1].ToString();
                txtApe.Text = row[2].ToString();
                txtUsuario.Text = row[3].ToString();
                txtPassword.Text = row[4].ToString();
                txtNom.Enabled = false;
                txtApe.Enabled = false;
                txtCedula.Enabled = false;
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
                cbxCargo.Enabled = false;
                btnAceptar.Visible = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            { MessageBox.Show("Error, no existe un usuario con esa identificación", "|  AVISO ~ ShoeSoft |"); }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;
            oper = 4;
            btnBuscar.Enabled = false;
            btnAgregar.Enabled = false;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IniciarC();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oper = 2;
            Habilitar();
            txtCedula.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oper = 3;
            if (MessageBox.Show("Seguro que deséa eliminar este usuario?.", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                EliminarUsuario();
            }
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.soloNumeros(sender,e);
            //clsVC.caracteresEspeciales(sender,e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.caracteresEspeciales(sender,e);
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender,e);
        }

        private void txtCedula_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender, e);
        }

        private void txtNom_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender, e);
        }

        private void txtApe_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender, e);
        }

        private void txtUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            clsVC.inhabilitarClicDerecho(sender, e);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.soloLetras(sender,e);
            //clsVC.espacios(sender,e);
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.soloLetras(sender, e);
            //clsVC.espacios(sender, e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsVC.caracteresEspeciales(sender,e);
        }

        private void Usuarios_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
