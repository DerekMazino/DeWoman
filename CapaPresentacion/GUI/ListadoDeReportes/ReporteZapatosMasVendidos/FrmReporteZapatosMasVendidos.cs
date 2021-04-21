using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMasVendidos
{
    public partial class FrmReporteZapatosMasVendidos : Form
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public FrmReporteZapatosMasVendidos()
        {
            InitializeComponent();
        }

        private void FrmReporteZapatosMasVendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteZapatosMasVendidos.RZapatosMasVendidos' Puede moverla o quitarla según sea necesario.
            this.RZapatosMasVendidosTableAdapter.Fill(this.ReporteZapatosMasVendidos.RZapatosMasVendidos, FechaInicio, FechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
