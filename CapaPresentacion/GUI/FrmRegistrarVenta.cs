using ProyectoInte.GUI.CLIENTES;
using ProyectoInte.GUI.INVENTARIO;
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
    public partial class FrmRegistrarVenta : Form
    {
        ClsValidarCampos VC = new ClsValidarCampos();
        private int contadorProductos;
        private int costoTotal;
        private List<ClsDetalleVenta> lst = new List<ClsDetalleVenta>();
        ClsVenta V = new ClsVenta();
        public FrmRegistrarVenta()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAgg, "Añadir producto");
            this.toolTip1.SetToolTip(this.btnElim, "Eliminar producto");
            this.toolTip1.SetToolTip(this.btnAcep, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");

        }
        private void GenerarIdVenta()
        {
            txtIdVenta.Text = V.GenerarIdVenta();
        }
        private void GenerarTipoPago()
        {
            cbxTipoPago.DataSource = V.ListarTipoPago();
            cbxTipoPago.DisplayMember = "TiPag";
            cbxTipoPago.ValueMember = "Id_Tpag";
        }
        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cancelarVenta();
            limpiar();
            inicializarDeNuevo();
            Close();
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
        private void btnAgg_Click(object sender, EventArgs e)
        {
            //Código de lo que hace el botón
            ClsProducto p = new ClsProducto();
            ClsDetalleVenta DV = new ClsDetalleVenta();
            if (txtNombresCliente.Text != "")
            {
                if (txtReferencia.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > 0)
                    {
                        if (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text))
                        {
                            DV.IdProducto = Convert.ToInt32(txtIdProducto.Text);
                            DV.RefProducto = txtReferencia.Text;
                            DV.Cantidad = Convert.ToInt32(txtCantidad.Text);
                            DV.PrecioVenta = Convert.ToInt32(txtPventa.Text);
                            lst.Add(DV);
                            LlenarDataGridView();
                            contadorProductos++;
                            costoTotal = costoTotal + (Convert.ToInt32(txtPventa.Text)*Convert.ToInt32(txtCantidad.Text));
                            txtTotal.Text = costoTotal + "";
                            p.Nombre = txtReferencia.Text;
                            p.Stock = Program.stockProducto - Convert.ToInt32(txtCantidad.Text);
                            p.SalidaDeProductos();
                            limpiar();
                        }
                        else { MessageBox.Show("No hay suficientes unidades en el inventario", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("No ha indicado la cantidad", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Seleccione un producto", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Seleccione al cliente", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnAgg_MouseHover(object sender, EventArgs e)
        {
            btnAgg.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgg.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //Fin boton agregar
        //Boton eliminar
        private void btnElim_Click(object sender, EventArgs e)
        {
            ClsProducto P = new ClsProducto();
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected == true)
                {
                    if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                    {
                        P.Nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        P.Stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        //t= Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        //re = Convert.ToInt32(txtCantidad.Text)-(P.Stock * t);
                        P.RecuperarProductos();
                        //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        lst.RemoveAt(dataGridView1.CurrentRow.Index);
                        LlenarDataGridView();
                        contadorProductos--;
                        MessageBox.Show("Producto Eliminado de la Lista Ok.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Existe Ningun Elemento en la Lista.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione Item a Eliminar de la Lista.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No Existe Ningun Elemento en la Lista", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTotal.Text = costoTotala() + "";
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
        // Boton Aceptar
        private void btnAcep_Click(object sender, EventArgs e)
        {

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
            cancelarVenta();
            limpiar();
            Close();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmListadoCliente C = new FrmListadoCliente();
            Program.Evento = 5;
            Program.EventoCompraVentaFabricacion = 999;
            C.Show();
        }

        private void FrmRegistrarVenta_Activated(object sender, EventArgs e)
        {
            Program.EventoCompraVentaFabricacion = 0;
            txtIDCliente.Text = Program.idCliente+"";
            txtNombresCliente.Text = Program.nombreCliente + " " + Program.apellidoCliente;
            txtDocIdentidad.Text = Program.cedulaCliente;
            txtIdProducto.Text = Program.idProducto+"";
            txtReferencia.Text = Program.nomProducto;
            txtStock.Text = Program.stockProducto + "";
            txtPventa.Text = Program.precioProducto + "";
            txtTotal.Text = costoTotala()+"";
        }

        private void btnBusquedaProducto_Click(object sender, EventArgs e)
        {
            FrmListadoProducto P = new FrmListadoProducto();
            Program.Evento = 6;
            Program.EventoCompraVentaFabricacion = 999;
            P.Show();
        }
        //Fin boton cancelar

        private void LlenarDataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lst[i].Cantidad;
                dataGridView1.Rows[i].Cells[1].Value = lst[i].IdProducto;
                dataGridView1.Rows[i].Cells[2].Value = lst[i].RefProducto;
                dataGridView1.Rows[i].Cells[3].Value = lst[i].PrecioVenta;
            }
            dataGridView1.ClearSelection();
        }

        private void limpiar()
        {
            Program.idProducto = 0;
            Program.nomProducto = "";
            Program.stockProducto = 0;
            Program.precioProducto = 0;
            txtIdProducto.Text = "";
            txtReferencia.Text = "";
            txtStock.Text = 0 + "";
            txtPventa.Text = 0 + "";
            txtCantidad.Text = 0 + "";
            //txtTotal.Text = 0 + "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GenerarIdVenta();
            GenerarTipoPago();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
        }
        private void cancelarVenta()
        {
            ClsProducto P = new ClsProducto();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToString(item.Cells[2].Value) != "")
                {
                    P.Nombre = item.Cells[2].Value.ToString();
                    P.Stock = Convert.ToInt32(item.Cells[0].Value.ToString());
                    P.RecuperarProductos();
                }
            }
        }

        private void btnCan_Click_1(object sender, EventArgs e)
        {
            cancelarVenta();
            limpiar();
            inicializarDeNuevo();
            Close();
        }

        private void btnAcep_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (txtNombresCliente.Text != "")
                {
                    V.IdUsuario = Program.idUsuario;
                    V.IdCliente = Program.idCliente;
                    V.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    V.TipoPago = Convert.ToInt32(cbxTipoPago.SelectedValue.ToString());
                    V.TotalPagar = Convert.ToInt32(txtTotal.Text);
                    MessageBox.Show(V.RegistrarVenta(), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Convert.ToInt32(cbxTipoPago.SelectedValue.ToString()) == 2)
                    {
                        V.PagarVentaCredito();
                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (Convert.ToString(item.Cells[2].Value) != "")
                        {
                            V.IdProducto = Convert.ToInt32(item.Cells[1].Value.ToString());
                            V.IdVenta = Convert.ToInt32(txtIdVenta.Text);
                            V.Cantidad = Convert.ToInt32(item.Cells[0].Value.ToString());
                            V.RegistrarDetalleVenta();
                        }
                    }
                    inicializarDeNuevo();
                    Close();
                }
                else
                {
                    MessageBox.Show("No ha seleccionado cliente", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Error, no ha seleccionado productos.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int costoTotala()
        {
            int costo = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    costo += Convert.ToInt32(item.Cells[0].Value.ToString()) * Convert.ToInt32(item.Cells[3].Value.ToString());
                }
            }
            return costo;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloNumeros(sender, e);
        }
        private void inicializarDeNuevo()
        {
            Program.idCliente = 0;
            Program.cedulaCliente = "";
            Program.apellidoCliente = "";
            Program.nombreCliente = "";
            Program.idProducto = 0;
            Program.nomProducto = "";
            Program.stockProducto = 0;
            Program.precioProducto = 0;
        }

        private void txtCantidad_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
    }
}
