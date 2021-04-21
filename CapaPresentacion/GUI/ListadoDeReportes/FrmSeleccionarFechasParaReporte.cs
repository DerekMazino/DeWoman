using ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles;
using ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesQueMenosCompran;
using ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMenosVendidos;
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
    public partial class FrmSeleccionarFechasParaReporte : Form
    {
        public FrmSeleccionarFechasParaReporte()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnGenerarReporte, "Generar reporte");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Evento == 777)
            {
                FrmReporteZapatosMasVendidos frmRZMV = new FrmReporteZapatosMasVendidos();
                frmRZMV.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                frmRZMV.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                frmRZMV.ShowDialog();
            }
            if (Program.Evento == 555)
            {
                FrmReporteZapatosMenosVendidos FrmR2 = new FrmReporteZapatosMenosVendidos();
                FrmR2.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                FrmR2.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                FrmR2.ShowDialog();
            }
            if (Program.Evento == 666)
            {
                FrmReporteTop5ClientesQueMasCompran FrmR3 = new FrmReporteTop5ClientesQueMasCompran();
                FrmR3.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                FrmR3.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                FrmR3.ShowDialog();
            }
            if (Program.Evento == 888)
            {
                FrmReporteClientesQueMenosCompran FrmR4 = new FrmReporteClientesQueMenosCompran();
                FrmR4.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                FrmR4.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                FrmR4.ShowDialog();
            }

        }

        private void FrmSeleccionarFechasParaReporte_Activated(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today.AddDays(-(int)DateTime.Today.Year + 1);
            dateTimePicker2.MinDate = DateTime.Today.AddDays(-(int)DateTime.Today.Year + 1);
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (Program.Evento == 777)
            {
                FrmReporteZapatosMasVendidos frmRZMV = new FrmReporteZapatosMasVendidos();
                frmRZMV.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                frmRZMV.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                frmRZMV.ShowDialog();
            }
            if (Program.Evento == 555)
            {
                FrmReporteZapatosMenosVendidos FrmR2 = new FrmReporteZapatosMenosVendidos();
                FrmR2.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                FrmR2.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                FrmR2.ShowDialog();
            }
            if (Program.Evento == 666)
            {
                FrmReporteTop5ClientesQueMasCompran FrmR3 = new FrmReporteTop5ClientesQueMasCompran();
                FrmR3.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                FrmR3.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                FrmR3.ShowDialog();
            }
            if (Program.Evento == 888)
            {
                FrmReporteClientesQueMenosCompran FrmR4 = new FrmReporteClientesQueMenosCompran();
                FrmR4.FechaInicio = Convert.ToDateTime(dateTimePicker1.Value);
                FrmR4.FechaFinal = Convert.ToDateTime(dateTimePicker2.Value);
                FrmR4.ShowDialog();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
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

        private void btnGenerarReporte_MouseHover(object sender, EventArgs e)
        {
            btnGenerarReporte.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnGenerarReporte_MouseLeave(object sender, EventArgs e)
        {
            btnGenerarReporte.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
