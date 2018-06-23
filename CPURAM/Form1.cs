using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPURAM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float Fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();

            progressBar1Cpu.Value = (int)Fcpu;
            progressBar2Ram.Value = (int)fram;

            LbCpu.Text = string.Format("{0:0.00}%", Fcpu);
            LbRam.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(Fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
