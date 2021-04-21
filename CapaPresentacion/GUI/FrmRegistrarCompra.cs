using CapaLogicaNegocio;
using ProyectoInte.GUI.INVENTARIO;
using ProyectoInte.GUI.PROVEEDORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.COMPRAS
{
    public partial class Compras : Form
    {
        ClsValidarCampos VC = new ClsValidarCampos();
        private int contadorProductos;
        private int costoTotal;
        private List<ClsDetalleCompra> lst = new List<ClsDetalleCompra>();
        ClsCompra C = new ClsCompra();
        public Compras()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar material");
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar material");
            this.toolTip1.SetToolTip(this.btnAcep, "Aceptar");
            this.toolTip1.SetToolTip(this.btnCan, "Cancelar");
        }
        private void GenerarIdCompra()
        {
            txtIdCompra.Text = C.GenerarIdCompra();
        }
        // Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiarMateriales();
            limpiarProveedor();
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
            ClsElemento m = new ClsElemento();
            ClsDetalleCompra DC = new ClsDetalleCompra();
            if (txtNit.Text != "")
            {
                if (txtIdMaterial.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > 0)
                    {
                        if (Convert.ToInt32(txtPcompra.Text) > 0)
                        {
                            DC.IdMaterial = Convert.ToInt32(txtIdMaterial.Text);
                            DC.Material = txtMaterial.Text;
                            DC.Cantidad = Convert.ToInt32(txtCantidad.Text);
                            DC.PrecioCompra = Convert.ToInt32(txtPcompra.Text);
                            lst.Add(DC);
                            LlenarDataGridView();
                            contadorProductos++;
                            costoTotal = costoTotal + (Convert.ToInt32(txtPcompra.Text) * Convert.ToInt32(txtCantidad.Text));
                            txtTotal.Text = costoTotal + "";
                            m.Nombre = txtMaterial.Text;
                            m.Stock = Program.stockMaterial - Convert.ToInt32(txtCantidad.Text);
                            limpiarMateriales();
                        }
                        else { MessageBox.Show("Debe colocar el precio de compra del producto", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("No ha indicado la cantidad", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Seleccione un producto", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Seleccione al proveedor", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
        //Boton eliminar
        private void btnElim_Click(object sender, EventArgs e)
        {
            //Código del boton
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
        // Boton Aceptar
        private void btnAcep_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (txtRazonSocial.Text != "")
                {
                    C.IdUsuario = Program.idUsuario;
                    C.IdProveedor = txtIdProveedor.Text;
                    C.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    C.TotalPagar = Convert.ToInt32(txtTotal.Text);
                    MessageBox.Show(C.RegistrarCompra(), " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (Convert.ToString(item.Cells[2].Value) != "")
                        {
                            C.IdMaterial = Convert.ToInt32(item.Cells[2].Value.ToString());
                            C.IdCompra = Convert.ToInt32(txtIdCompra.Text);
                            C.Cantidad = Convert.ToInt32(item.Cells[1].Value.ToString());
                            C.ValorMaterial = Convert.ToInt32(item.Cells[4].Value.ToString());
                            C.RegistrarDetalleCompra();
                        }
                    }
                    inicializarDeNuevo();
                    Close();
                }
                else
                {
                    MessageBox.Show("No ha seleccionado cliente", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, no ha seleccionado productos.", " | AVISO ~ShoeSoft | ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            limpiarMateriales();
            limpiarProveedor();
            Close();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmListadoProveedores pro = new FrmListadoProveedores();
            Program.EventoCompraVentaFabricacion = 999;
            Program.Evento = 5;
            pro.ShowDialog();
        }

        private void btnBusquedaProducto_Click(object sender, EventArgs e)
        {
            FrmListadoMateriales mat = new FrmListadoMateriales();
            Program.EventoCompraVentaFabricacion = 999;
            Program.Evento = 7;
            mat.ShowDialog();
        }

        private void Compras_Activated(object sender, EventArgs e)
        {
            txtIdProveedor.Text = Program.idProveedor + "";
            txtNit.Text = Program.nit;
            txtRazonSocial.Text = Program.razsoc;
            txtIdMaterial.Text = Program.idmaterial + "";
            txtMaterial.Text = Program.material;
            txtStock.Text = Program.stockMaterial + "";
            txtPcompra.Text = 0 + "";
            txtCantidad.Text = 0 + "";
        }
        //Fin boton cancelar
        private int costoTotala()
        {
            int costo = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    costo += Convert.ToInt32(item.Cells[1].Value.ToString()) * Convert.ToInt32(item.Cells[4].Value.ToString());
                }
            }
            return costo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected == true)
                {
                    if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                    {
                        //t= Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        //re = Convert.ToInt32(txtCantidad.Text)-(P.Stock * t);
                        //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        lst.RemoveAt(dataGridView1.CurrentRow.Index);
                        LlenarDataGridView();
                        contadorProductos--;
                        MessageBox.Show("Producto Eliminado de la Lista Ok.", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Existe Ningun Elemento en la Lista.", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione Item a Eliminar de la Lista.", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No Existe Ningun Elemento en la Lista", " | AVISO ~ShoeSoft |  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTotal.Text = costoTotala() + "";
        }

        private void LlenarDataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = lst[i].Cantidad;
                dataGridView1.Rows[i].Cells[2].Value = lst[i].IdMaterial;
                dataGridView1.Rows[i].Cells[3].Value = lst[i].Material;
                dataGridView1.Rows[i].Cells[4].Value = lst[i].PrecioCompra;
            }
            dataGridView1.ClearSelection();
        }

        private void limpiarMateriales()
        {
            Program.idmaterial = 0;
            Program.material = "";
            Program.stockMaterial = 0;
            txtIdMaterial.Text = Program.idmaterial + "";
            txtMaterial.Text = Program.material;
            txtStock.Text = Program.stockMaterial + "";
            txtPcompra.Text = 0 + "";
            txtCantidad.Text = 0 + "";
        }
        private void limpiarProveedor()
        {
            Program.idProveedor = 0;
            Program.nit = 0+"";
            Program.razsoc = "";
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GenerarIdCompra();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
        }
        private void inicializarDeNuevo()
        {
            Program.idProveedor=  0;
            Program.nit="";
            Program.razsoc="";
            Program.idmaterial = 0;
            Program.material="";
            Program.stockMaterial=0;
            //txtTotal.Text = costoTotala() + "";
        }

        private void txtPcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloNumeros(sender,e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            VC.soloNumeros(sender,e);
        }

        private void txtCantidad_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }

        private void txtPcompra_MouseDown(object sender, MouseEventArgs e)
        {
            ClsValidarCampos VC = new ClsValidarCampos();
            VC.inhabilitarClicDerecho(sender, e);
        }
    }
}
