using ProyectoInte.GUI.ListadoDeReportes.ProductosConPocasExistencias;
using ProyectoInte.GUI.ListadoDeReportes.ReporteTop5ClientesFieles;
using ProyectoInte.GUI.ListadoDeReportes.ReporteZapatosMasVendidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte.GUI.ListadoDeReportes
{
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Evento = 777;
            FrmSeleccionarFechasParaReporte S = new FrmSeleccionarFechasParaReporte();
            S.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Evento = 555;
            FrmSeleccionarFechasParaReporte S = new FrmSeleccionarFechasParaReporte();
            S.ShowDialog();
        }

        private void MenuReportes_Activated(object sender, EventArgs e)
        {
            Program.Evento = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmReporteProductosAgotados Ag = new FrmReporteProductosAgotados();
            Ag.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Evento = 666;
            FrmSeleccionarFechasParaReporte S = new FrmSeleccionarFechasParaReporte();
            S.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Evento = 888;
            FrmSeleccionarFechasParaReporte S = new FrmSeleccionarFechasParaReporte();
            S.ShowDialog();
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
    }
}
