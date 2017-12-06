using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ResourceMonitor
{
    public partial class ResourceMonitor : Form
    {
        public ResourceMonitor() => InitializeComponent();

        float previousU = 0;
        float previousD = 0;
        float tempU = 0;
        float tempD = 0;
        float upload = 0;
        float download = 0;

        //Update Info per Second
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Get System Values
            float cpu = cpuPerf.NextValue();
            float ramAv = ramPerfAv.NextValue();
            float ramPerc = ramPerfPerc.NextValue();

            IPv4InterfaceStatistics network;
            network = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();

            //convert to Bits
            tempU = network.BytesSent * 8;
            tempD = network.BytesReceived * 8;

            upload = tempU - previousU;
            download = tempD - previousD;
            previousU = tempU;
            previousD = tempD;

            //Bar values
            cpuBar.Value = (int)cpu;
            ramBar.Value = (int)ramPerc;

            //Text Values
            cpuText.Text = string.Format("{0:0.00}%", cpu);
            ramText.Text = string.Format("{0:0.00} GB FREE", ramAv/1000);

            
            //Upload Text Values
            if(upload > 1000000000.00)
                upText.Text = string.Format("{0:0.00} Gb/s", upload / 1000000000.00);
            else if(upload > 1000000.00)
                upText.Text = string.Format("{0:0.00} Mb/s", upload / 1000000.00);
            else if (upload > 1000.00)
                upText.Text = string.Format("{0:0.00} Kb/s", upload / 1000.00);
            else
                upText.Text = string.Format("{0:0.00} b/s", upload);

            //Download Text Values
            if (download > 1000000000.00)
                downText.Text = string.Format("{0:0.00} Gb/s", download / 1000000000.00);
            else if (download > 1000000.00)
                downText.Text = string.Format("{0:0.00} Mb/s", download / 1000000.00);
            else if (download > 1000.00)
                downText.Text = string.Format("{0:0.00} Kb/s", download / 1000.00);
            else
                downText.Text = string.Format("{0:0.00} b/s", download);
        }

        //Start Timer
        private void Form1_Load(object sender, EventArgs e) => Timer.Start();
    }
}
