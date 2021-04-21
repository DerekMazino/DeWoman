using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.ListadoDeReportes.ProductosConPocasExistencias
{
    public partial class FrmReporteProductosAgotados : Form
    {
        public FrmReporteProductosAgotados()
        {
            InitializeComponent();
        }

        private void FrmReporteProductosAgotados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReportePocasExistenciasProductos.RProductosConPocasExistencias' Puede moverla o quitarla según sea necesario.
            this.RProductosConPocasExistenciasTableAdapter.Fill(this.ReportePocasExistenciasProductos.RProductosConPocasExistencias);

            this.reportViewer1.RefreshReport();
        }
    }
}
