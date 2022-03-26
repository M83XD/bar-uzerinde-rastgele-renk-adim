using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Color[] renkler = { Color.Pink, Color.Red, Color.ForestGreen, Color.DeepPink, Color.CadetBlue };
            Random rnd = new Random();
            progressBar1.ForeColor = renkler[rnd.Next(renkler.Length)];
            progressBar2.ForeColor = renkler[rnd.Next(renkler.Length)];
            progressBar3.ForeColor = renkler[rnd.Next(renkler.Length)];
            progressBar4.ForeColor = renkler[rnd.Next(renkler.Length)];
            progressBar5.ForeColor = renkler[rnd.Next(renkler.Length)];
            progressBar6.ForeColor = renkler[rnd.Next(renkler.Length)];

            int[] xd = new int[6];
            xd = new int[6];
            xd[0] = 50;
            xd[1] = 24;
            xd[2] = 80;
            xd[3] = 99;
            xd[4] = 4;
            xd[5] = 15;

            progressBar1.Value = xd[rnd.Next(xd.Length)]; ;
            progressBar2.Value = xd[rnd.Next(xd.Length)]; ;
            progressBar3.Value = xd[rnd.Next(xd.Length)]; ;
            progressBar4.Value = xd[rnd.Next(xd.Length)]; ;
            progressBar5.Value = xd[rnd.Next(xd.Length)]; ;
            progressBar6.Value = xd[rnd.Next(xd.Length)]; ;

        }
    }
}
