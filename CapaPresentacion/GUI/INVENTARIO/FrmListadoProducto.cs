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
using System.IO;
namespace ProyectoInte.GUI.INVENTARIO
{
    public partial class FrmListadoProducto : Form
    {
        ClsValidarCampos V = new ClsValidarCampos();
        ClsProducto P = new ClsProducto();
        public FrmListadoProducto()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAgg,"Añadir producto");
            this.toolTip1.SetToolTip(this.btnEdit, "Editar producto");
            this.toolTip1.SetToolTip(this.btnElim, "Eliminar producto");
            this.toolTip1.SetToolTip(this.Imagen, "Imagen del producto");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Código de lo que hace el botón
            FrmRegistrarProducto producto = new FrmRegistrarProducto();
            Program.Evento = 1;
            dataGridView1.ClearSelection();
            producto.ShowDialog();
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
                    FrmRegistrarProducto FrmP = new FrmRegistrarProducto();
                    FrmP.txtRefe.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    FrmP.txtRefe.Enabled = false;
                    FrmP.txtPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    cargarImagenPictureBox(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    FrmP.pictureBox1.Image = Imagen.Image;
                    FrmP.txtRefe.Focus();
                    FrmP.Show();
                    if (dataGridView1.SelectedRows.Count > 0)
                        Program.Evento = 2;
                    else
                        Program.Evento = 0;
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione la Fila a Editar.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ListarProducto();
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
                        msj = P.eliminarProducto(seleccion);
                        MessageBox.Show(msj, "|  AVISO ~ ShoeSoft |");
                        ListarProducto();
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
            ListarProducto();
        }
        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnElim.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnElim.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void txtBuscarPro_MouseDown(object sender, MouseEventArgs e)
        {
            V.inhabilitarClicDerecho(sender, e);
        }

        private void txtBuscarPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.BloquearTeclaControl(sender, e);
            V.caracteresEspeciales(sender, e);
           
        }
        // Fin boton eliminar

        private void ListarProducto()
        {
            DataTable dt = new DataTable();
            dt = P.ListadoProducto();
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
                    //pictureBox2.Image= ClsConvertImage.ByteArrayToImage((byte[])dt.Rows[i][4]);
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][5].ToString();

                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmListadoProducto_Load(object sender, EventArgs e)
        {
            ListarProducto();
        }

        private void FrmListadoProducto_Activated(object sender, EventArgs e)
        {
            ListarProducto();
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
            //pictureBox1.Image = null;
        }

        private void txtBuscarPro_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPro.TextLength > 0)
            {

                DataTable dt = new DataTable();
                P.Nombre = txtBuscarPro.Text;
                dt = P.BuscarProducto(P.Nombre);
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
                        //pictureBox2.Image = ClsConvertImage.ByteArrayToImage((byte[])dt.Rows[i][4]);
                        dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][5].ToString();
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
                ListarProducto();
            }
        }
        private String seleccion;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                cargarImagenPictureBox(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
                seleccion = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            /*if (Program.Evento == 2) {
                FrmFabricacion FrmF = new FrmFabricacion();
                Program.idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Program.nomProducto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.stockProducto= Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                this.Close();
            }*/
            if (Program.Evento == 6)
            {
                Program.idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Program.nomProducto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.precioProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                Program.stockProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                Close();
            }
        }
        private void cargarImagenPictureBox(int id)
        {
            DataTable dt = new DataTable();
            dt = P.CargarImagen(id);
            try
            {
                //dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Imagen.Image = ClsConvertImage.ByteArrayToImage((byte[])dt.Rows[i][0]);
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
