using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Hacking_Tools
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sqlmap sql_mp = new sqlmap();
            sql_mp.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            googlehack gh = new googlehack();
            gh.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            google_hackk ghk = new google_hackk();
            ghk.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            google_dork_ham dfg = new google_dork_ham();
            dfg.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Porttarama p = new Porttarama();
            p.ShowDialog();
            //Process.Start(Application .StartupPath+""+ "\\Porttarama\\advanced_ip_scanner.exe");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sıkıstırma sı = new sıkıstırma();
            sı.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ftpbrovser f = new ftpbrovser();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            keylogger kg = new keylogger();
            kg.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            keylogger kg = new keylogger();
            kg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
