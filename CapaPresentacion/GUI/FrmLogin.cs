using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CapaLogicaNegocio;
namespace ProyectoInte
{
    public partial class Login : Form
    {
        ClsUsuario clsU = new ClsUsuario();
        public Login()
        {
            /* Thread tardar = new Thread(new ThreadStart(pantalla));
             tardar.Start();
             Thread.Sleep(10000);*/
            InitializeComponent();
            /*  tardar.Abort();   
            */
            this.toolTip1.SetToolTip(this.btnMini, "Minimizar");
            this.toolTip1.SetToolTip(this.btnOff, "Cerrar ShoeSoft");
            this.toolTip1.SetToolTip(this.pcIngresar, "Iniciar sesión");
        }


        private void Login_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 alto = (desktopSize.Height - 280) / 2;
            Int32 ancho = (desktopSize.Width - 500) / 2;
            panel1.Location = new Point(ancho, alto);
            //Fin central el Panel

            //Mostrar Fecha y Hora
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        public void pantalla()
        {
            Application.Run(new SplashScreen());
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Salir.", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pcIngresar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "")
            {
                if (txtClave.Text != "")
                {
                    String Mensaje = "";
                    clsU.Nusuario = txtuser.Text;
                    clsU.Contraseña = txtClave.Text;
                    Mensaje = clsU.IniciarSesion();
                    if (Mensaje == "La contraseña es incorrecta.")
                    {
                        MessageBox.Show(Mensaje, "|  AVISO ~ ShoeSoft |", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtClave.Clear();
                        txtClave.Focus();
                    }
                    else
                    {
                        if (Mensaje == "El nombre de usuario no existe.")
                        {
                            MessageBox.Show(Mensaje, "|  AVISO ~ ShoeSoft |", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            txtuser.Clear();
                            txtClave.Clear();
                            txtuser.Focus();
                        }
                        else
                        {
                            MessageBox.Show(Mensaje, "|  AVISO ~ ShoeSoft |", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Principal P = new Principal();
                            RecuperarDatosSesion();
                            P.Visible = true;
                            Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese la contraseña", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtClave.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el nombre de usuario", "|  AVISO ~ ShoeSoft |", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void pcIngresar_MouseHover(object sender, EventArgs e)
        {
            pcIngresar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pcIngresar_MouseLeave(object sender, EventArgs e)
        {
            pcIngresar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnOff_MouseHover(object sender, EventArgs e)
        {
            btnOff.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnOff_MouseLeave(object sender, EventArgs e)
        {
            btnOff.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMini_MouseHover(object sender, EventArgs e)
        {
            btnMini.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.BackgroundImageLayout = ImageLayout.Zoom;
        }

        void limpiarCampos()
        { txtuser.Text = ""; txtClave.Text = ""; }
        private void RecuperarDatosSesion()
        {
            DataRow row;
            DataTable dt = new DataTable();
            dt = clsU.DevolverDatosSesion(txtuser.Text, txtClave.Text);
            if (dt.Rows.Count == 1)
            {
                row = dt.Rows[0];
                Program.idUsuario = row[0].ToString();
                Program.nombreUsu = row[1].ToString();
                Program.idCargo = Convert.ToInt32(row[2].ToString());
                Program.tipoUsuario = row[3].ToString();
            }
        }

        private void txtuser_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtClave_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
    }
}