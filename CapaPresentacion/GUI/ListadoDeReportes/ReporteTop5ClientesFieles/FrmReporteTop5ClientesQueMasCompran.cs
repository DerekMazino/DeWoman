using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles
{
    public partial class FrmReporteTop5ClientesQueMasCompran : Form
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public FrmReporteTop5ClientesQueMasCompran()
        {
            InitializeComponent();
        }

        private void FrmReporteTop5ClientesQueMasCompran_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteTop5ClientesFieles.RClientesQueMasCompran' Puede moverla o quitarla según sea necesario.
            this.RClientesQueMasCompranTableAdapter.Fill(this.ReporteTop5ClientesFieles.RClientesQueMasCompran,FechaInicio, FechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
