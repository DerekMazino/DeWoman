using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMenosVendidos
{
    public partial class FrmReporteZapatosMenosVendidos : Form
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public FrmReporteZapatosMenosVendidos()
        {
            InitializeComponent();
        }

        private void FrmReporteZapatosMenosVendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteZapatosMenosVendidos.RZapatosMenosVendidos' Puede moverla o quitarla según sea necesario.
            this.RZapatosMenosVendidosTableAdapter.Fill(this.ReporteZapatosMenosVendidos.RZapatosMenosVendidos, FechaInicio, FechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
