using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesQueMenosCompran
{
    public partial class FrmReporteClientesQueMenosCompran : Form
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public FrmReporteClientesQueMenosCompran()
        {
            InitializeComponent();
        }

        private void FrmReporteClientesQueMenosCompran_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteTop5ClientesQueMenosCompran.RClientesQueMenosCompran' Puede moverla o quitarla según sea necesario.
            this.RClientesQueMenosCompranTableAdapter.Fill(this.ReporteTop5ClientesQueMenosCompran.RClientesQueMenosCompran, FechaInicio, FechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
