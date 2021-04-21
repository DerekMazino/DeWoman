using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInte
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
