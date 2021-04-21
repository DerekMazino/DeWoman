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
    public partial class FrmListadoMateriales : Form
    {
        ClsElemento E = new ClsElemento();
        public FrmListadoMateriales()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAgg, "Añadir materiales");
            this.toolTip1.SetToolTip(this.btnEdit, "Editar materiales");
            this.toolTip1.SetToolTip(this.btnElim, "Eliminar materiales");

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
        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgg.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgg.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton agregar
        //Boton editar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Código del boton     
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    FrmRegistrarMaterial FrmM = new FrmRegistrarMaterial();
                    FrmM.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    FrmM.txtMat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    FrmM.txtMat.Focus();
                    FrmM.Show();
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
                ListarMaterial();
            }
            dataGridView1.ClearSelection();
        }
        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton editar

        //Boton eliminar
        private void btnElim_Click(object sender, EventArgs e)
        {
            //Código del boton
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que desea eliminar este registro?", " | AVISO ~ShoeSoft | ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    String msj = "";
                    try
                    {
                        msj = E.eliminarMaterial(seleccion);
                        MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                        ListarMaterial();
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
            ListarMaterial();
        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnElim.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnElim.BackgroundImageLayout = ImageLayout.Zoom;
        }
        // Fin boton eliminar
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
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmListadoMateriales_Load(object sender, EventArgs e)
        {
            ListarMaterial();
        }

        private void FrmListadoMateriales_Activated(object sender, EventArgs e)
        {
            ListarMaterial();
            if (Program.idCargo == 2)
            {
                btnElim.Visible = false;
            }
            if (Program.EventoCompraVentaFabricacion == 999)
            {
                btnAgg.Visible = false;
                btnEdit.Visible = false;
                btnElim.Visible = false;
            }
        }

        private void txtBuscarPro_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPro.TextLength > 0)
            {

                DataTable dt = new DataTable();
                E.Nombre = txtBuscarPro.Text;
                dt = E.BuscarMateruial(E.Nombre);
                try
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dt.Rows[i][0]);
                        dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
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
                ListarMaterial();
            }
        }
        private String seleccion;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                seleccion = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            }
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            FrmRegistrarMaterial mat = new FrmRegistrarMaterial();
            Program.Evento = 0;
            dataGridView1.ClearSelection();
            mat.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.Evento == 7)
            {
                Program.idmaterial= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Program.material= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.stockMaterial= Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                Close();
            }
        }

        private void txtBuscarPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.BloquearTeclaControl(sender, e);
            VC.caracteresEspeciales(sender,e);
        }

        private void txtBuscarPro_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
    }
}

