using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceMonitor
{
    public partial class ResourceMonitor : Form
    {
        public ResourceMonitor() => InitializeComponent();

        private void Timer_Tick(object sender, EventArgs e)
        {
            float fcpu = cpuPerf.NextValue();

            cpubar.Value = (int)fcpu;

            perCPU.Text = string.Format("{0:0.00}%", fcpu);
        }

        private void Form1_Load(object sender, EventArgs e) => Timer.Start();
    }
}
