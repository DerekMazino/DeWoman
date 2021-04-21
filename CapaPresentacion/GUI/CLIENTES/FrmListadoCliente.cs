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
using ProyectoInte.GUI.CLIENTES.ReporteListadoClientes;

namespace ProyectoInte.GUI.CLIENTES
{
    public partial class FrmListadoCliente : Form
    {
        ClsCliente C = new ClsCliente();
        public FrmListadoCliente()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAgregar, "Añadir cliente");
            this.toolTip1.SetToolTip(this.btnEditar, "Editar cliente");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar cleinte");
            this.toolTip1.SetToolTip(this.btnAbonar, "Abonar crédito cliente");
            this.toolTip1.SetToolTip(this.btnImprimir, "Generar listado clientes");

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
            FrmRegistrarClientes cliente = new FrmRegistrarClientes();
            Program.Evento = 0;
            dataGridView1.ClearSelection();
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
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    FrmRegistrarClientes FrmC = new FrmRegistrarClientes();
                    FrmC.txtCedula.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    FrmC.txtCedula.Enabled = false;
                    FrmC.txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    FrmC.txtApellido.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    FrmC.txtEmpresa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    FrmC.txtDireccion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    FrmC.txtTelefono.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    FrmC.txtCedula.Focus();
                    FrmC.Show();
                    if (dataGridView1.SelectedRows.Count > 0)
                        Program.Evento = 1;
                    else
                        Program.Evento = 0;
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione la Fila a Editar.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ListarClientes();
            }
            dataGridView1.ClearSelection();
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que desea eliminar este registro?", " | AVISO ~ShoeSoft | ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    String msj = "";
                    try
                    {
                        msj = C.eliminarCliente(seleccion);
                        MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                        ListarClientes();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "|  AVISO ~ ShoeSoft |");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Eliminar.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListarClientes();
        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
        private void ListarClientes()
        {
            DataTable dt = new DataTable();
            dt = C.ListadoClientes();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();

                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.TextLength > 0)
                {

                    DataTable dt = new DataTable();
                    C.Nombre = textBox1.Text;
                    dt = C.BuscarCliente(C.Nombre);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dt.Rows[i][0]);
                            dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                            dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                            dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                            dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                            dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                            dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                            dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                            dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                        }
                        dataGridView1.ClearSelection();
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    ListarClientes();
                }

            }
        }

        private void FrmListadoCliente_Activated(object sender, EventArgs e)
        {
            ListarClientes();
            if (Program.idCargo == 2)
            {
                btnAbonar.Visible = false;
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnImprimir.Visible = false;
            }
            if (Program.EventoCompraVentaFabricacion == 999)
            {
                btnAbonar.Visible = false;
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnImprimir.Visible = false;

            }
        }
        private String seleccion;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                seleccion = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Cedula"].Value);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.Evento == 5)
            {
                Program.idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Program.cedulaCliente = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.apellidoCliente = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Program.nombreCliente = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Close();
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    FrmPagarCredito FrmPC = new FrmPagarCredito();
                    FrmPC.txtIdCliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    FrmPC.txtDocIdentidad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    FrmPC.txtNombresCliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() +" "+ dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    FrmPC.txtSaldo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    FrmPC.ShowDialog();
                    if (dataGridView1.SelectedRows.Count > 0)
                        Program.Evento = 1;
                    else
                        Program.Evento = 0;
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Por Favor seleccione una fila.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ListarClientes();
            }
            dataGridView1.ClearSelection();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmReporteListadoClientes frlc = new FrmReporteListadoClientes();
            frlc.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    FrmPagarCredito FrmPC = new FrmPagarCredito();
                    FrmPC.txtIdCliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    FrmPC.txtDocIdentidad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    FrmPC.txtNombresCliente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    FrmPC.txtSaldo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    FrmPC.ShowDialog();
                    if (dataGridView1.SelectedRows.Count > 0)
                        Program.Evento = 1;
                    else
                        Program.Evento = 0;
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Por Favor seleccione una fila.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ListarClientes();
            }
            dataGridView1.ClearSelection();
        }
        private void btnAbonar_MouseHover(object sender, EventArgs e)
        {
            btnAbonar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAbonar_MouseLeave(object sender, EventArgs e)
        {
            btnAbonar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.BloquearTeclaControl(sender, e);
            VC.caracteresEspeciales(sender,e);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
    }
}
