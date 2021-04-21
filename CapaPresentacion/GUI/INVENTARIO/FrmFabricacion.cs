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
using ProyectoInte.GUI.INVENTARIO;

namespace ProyectoInte.GUI
{
    public partial class FrmFabricacion : Form
    {
        ClsValidarCampos VL = new ClsValidarCampos();
        private int n, re;
        ClsElemento E = new ClsElemento();
        ClsFabricacion F = new ClsFabricacion();
        public FrmFabricacion()
        {
            InitializeComponent();
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar referencia del Producto");
            this.toolTip1.SetToolTip(this.btnAcep, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");
        }
        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            inicializarTodo();
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
            if (validarDataGrid())
            {
                if (txtNombreProducto.Text != "")
                {
                    if (Convert.ToInt32(txtNPosibles.Text) >= Convert.ToInt32(txtNaCrear.Text))
                    {
                        F.ReferenciaProducto = txtNombreProducto.Text;
                        F.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                        F.CantidadEntradaProductos = Convert.ToInt32(txtNaCrear.Text);
                        F.CantidadActualProducto = Program.stockProducto;
                        F.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            if (bool.Parse(item.Cells[4].Value.ToString()) == true && item.Cells[3].Value.ToString() != "0")
                            {
                                F.IdMaterial = Convert.ToInt32(item.Cells[0].Value.ToString());
                                F.CantidadActualMaterial = Convert.ToInt32(item.Cells[2].Value.ToString());
                                F.CantidadSalidaMateriales = Convert.ToInt32(item.Cells[3].Value.ToString()) * Convert.ToInt32(txtNaCrear.Text);
                                F.RegistrarPROMAT();
                                F.SalidaMateriales();
                                F.RegistrarSalMat();
                            }
                        }
                        F.EntradaDeProductos();

                        MessageBox.Show(F.RegistrarEntPro(), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No es posible fabricar " + txtNaCrear.Text + " ya que no hay material suficiente", "| AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione el producto a fabricar.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                inicializarTodo();
                Close();
            }
            else {
                MessageBox.Show("Error, Uno(s) de los materiales seleccionado tiene 0 unds en el inventario", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            inicializarTodo();
            Close();
        }
        //Fin boton cancelar
        //Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmListadoProducto LP = new FrmListadoProducto();
            Program.EventoCompraVentaFabricacion = 999;
            Program.Evento = 6;
            LP.ShowDialog();
        }
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton Buscar
        private void ListarMaterial()
        {
            DataTable dt = new DataTable();
            dt = E.ListadoMateriales();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = "0";
                    dataGridView1.Rows[i].Cells[4].Value = "false";
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmFabricacion_Load(object sender, EventArgs e)
        {
            ListarMaterial();
        }

        private void FrmFabricacion_Activated(object sender, EventArgs e)
        {
            ListarMaterial();
            txtIdProducto.Text = Program.idProducto + "";
            txtNombreProducto.Text = Program.nomProducto;
            txtStockProducto.Text = Program.stockProducto + "";
            txtNPosibles.Text = "0";
            /*if (txtIdProducto.Text == "")
            {
                dataGridView1.ReadOnly = false;
            }
            else
            {
                dataGridView1.ReadOnly = true;
            }*/
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                MessageBox.Show("Por favor seleccione un producto", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (e.RowIndex == -1)
                    return;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Seleccionar")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccionar"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        n = 0;
                        re = 0;
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.Cells[3].ReadOnly = false;
                        if (row.Cells[2].Value.ToString() != "0")
                        {
                            row.Cells[3].Value = "1";
                        }
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.Cells[3].ReadOnly = true;
                        row.Cells[3].Value = "0";
                        n = 0;
                        re = 0;
                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.CurrentRow.Cells[3].ColumnIndex)
                {

                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString()) > Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()))
                    {
                        //MessageBox.Show("Error, no hay material suficiente");
                        dataGridView1.CurrentRow.Cells[3].Value = "1";
                    }
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString()) <= 0) { dataGridView1.CurrentRow.Cells[3].Value = "1"; }
                    if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()) == 0) { dataGridView1.CurrentRow.Cells[3].Value = "0"; }
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int reps=0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (bool.Parse(item.Cells[4].Value.ToString()) == true && item.Cells[3].Value.ToString()!="0")
                {
                    if (n == 0)
                    {
                        n = (int)(Convert.ToInt32(item.Cells[2].Value.ToString()) / Convert.ToInt32(item.Cells[3].Value.ToString()));
                    }
                    else
                    {
                        re = (int)(Convert.ToInt32(item.Cells[2].Value.ToString()) / Convert.ToInt32(item.Cells[3].Value.ToString()));
                        if (re < n)
                        {
                            reps = re;
                        }
                        else { reps = n; }
                    }
                }
            }
            txtNPosibles.Text = reps + "";
            if (n != 0) { btnAcep.Enabled = true; txtNaCrear.Enabled = true; }
        }
        private void inicializarTodo()
        {
            Program.idProducto = 0;
            Program.stockProducto = 0;
            Program.nomProducto = "";
            Program.precioProducto = 0;
            n = 0;
            txtNaCrear.Text = "0";
        }

        private void txtNaCrear_KeyPress(object sender, KeyPressEventArgs e)
        {
            VL.soloNumeros(sender, e);
            VL.BloquearTeclaControl(sender, e);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtNaCrear_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }

        private bool validarDataGrid()
        {
            bool resp=false;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (bool.Parse(item.Cells[4].Value.ToString()) == true )
                {
                    if (item.Cells[3].Value.ToString() == "0"){resp = false;}
                    else { resp = true; }
                }
            }
            return resp;
        }
    }
}
