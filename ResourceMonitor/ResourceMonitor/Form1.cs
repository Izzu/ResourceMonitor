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

        //Update Info per Second
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Get System Values
            float cpu = cpuPerf.NextValue();
            float ramAv = ramPerfAv.NextValue();
            float ramPerc = ramPerfPerc.NextValue();

            //Bar values
            cpuBar.Value = (int)cpu;
            ramBar.Value = (int)ramPerc;

            cpuPerc.Text = string.Format("{0:0.00}%", cpu);
            ramAmt.Text = string.Format("{0:0.00} GB FREE", ramAv/1000);
        }

        //Start Timer
        private void Form1_Load(object sender, EventArgs e) => Timer.Start();
    }
}
