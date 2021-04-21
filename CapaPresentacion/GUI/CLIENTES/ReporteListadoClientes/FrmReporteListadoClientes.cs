using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.CLIENTES.ReporteListadoClientes
{
    public partial class FrmReporteListadoClientes : Form
    {
        public FrmReporteListadoClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteListadoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteListadoClientes.ListarClientes' Puede moverla o quitarla según sea necesario.
            this.ListarClientesTableAdapter.Fill(this.ReporteListadoClientes.ListarClientes);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
