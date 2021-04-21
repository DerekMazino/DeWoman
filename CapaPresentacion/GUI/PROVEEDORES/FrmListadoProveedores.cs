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
using ProyectoInte.GUI.PROVEEDORES.ReporteListadoProoveedores;

namespace ProyectoInte.GUI.PROVEEDORES
{
    public partial class FrmListadoProveedores : Form
    {
        ClsEmpresa E = new ClsEmpresa();
        public FrmListadoProveedores()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtBuscar, "Ingrese Nombre o Razón Social del Proveedor");
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar un Proveedor");
            this.toolTip1.SetToolTip(this.btnEditar, "Editar un Proveedor");
            this.toolTip1.SetToolTip(this.btnEliminar, "ELiminar un Proveedor");
            this.toolTip1.SetToolTip(this.btnImprimir, "Generar listado de Proveedores");
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
            FrmRegistarProveedores proveedor = new FrmRegistarProveedores();
            Program.Evento = 0;
            dataGridView1.ClearSelection();
            proveedor.ShowDialog();
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
                    FrmRegistarProveedores FrmP = new FrmRegistarProveedores();
                    FrmP.txtNit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    FrmP.txtNit.Enabled = false;
                    FrmP.txtRacSoc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    FrmP.txtDireccion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    FrmP.txtTelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    FrmP.txtNit.Focus();
                    FrmP.Show();
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
                ListarProveedor();
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
            //Código del boton
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que desea eliminar este registro?", " | AVISO ~ShoeSoft | ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    String msj = "";
                    try
                    {
                        msj = E.eliminarProveedor(seleccion);
                        MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                        ListarProveedor();
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
            ListarProveedor();
        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        // Fin boton eliminar

        private void ListarProveedor()
        {
            DataTable dt = new DataTable();
            dt = E.ListadoProveedor();
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
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtBuscar.TextLength > 0)
                {

                    DataTable dt = new DataTable();
                    E.Nombre = txtBuscar.Text;
                    dt = E.BuscarProveedor(E.Nombre);
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
                    ListarProveedor();
                }

            }
        }

        private void FrmListadoProveedores_Activated(object sender, EventArgs e)
        {
            ListarProveedor();
            if (Program.idCargo == 2)
            {
                btnEliminar.Visible = false;
            }
            if (Program.EventoCompraVentaFabricacion == 999)
            {
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnImprimir.Visible = false;
            }
        }
        private String seleccion;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                seleccion = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nit"].Value);
            }
        }

        private void FrmListadoProveedores_Load(object sender, EventArgs e)
        {
            ListarProveedor();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.Evento == 5)
            {
                Program.idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Program.nit = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.razsoc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Close();
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmReporteListadoProveedores frlp = new FrmReporteListadoProveedores();
            frlp.ShowDialog();
        }
        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.BloquearTeclaControl(sender, e);
            VC.caracteresEspeciales(sender,e);
        }
    }
}
