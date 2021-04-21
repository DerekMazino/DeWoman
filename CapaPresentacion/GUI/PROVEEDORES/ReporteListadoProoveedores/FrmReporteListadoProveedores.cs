using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.PROVEEDORES.ReporteListadoProoveedores
{
    public partial class FrmReporteListadoProveedores : Form
    {
        public FrmReporteListadoProveedores()
        {
            InitializeComponent();
        }

        private void FrmReporteListadoProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteListadoProveedores.ListarProveedores' Puede moverla o quitarla según sea necesario.
            this.ListarProveedoresTableAdapter.Fill(this.ReporteListadoProveedores.ListarProveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
