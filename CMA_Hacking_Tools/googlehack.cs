using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Hacking_Tools
{
    public partial class googlehack : MetroForm
    {
        public googlehack()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void metroButton3_Click(object sender, EventArgs e)
        {
            StreamReader s = new StreamReader(Application.StartupPath + "\\Dork.txt");
            string satir;          
            while ((satir = s.ReadLine()) != null)
            {
                listBox4.Items.Add(satir);
                sayac++;
            }
            s.Close();

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox4.SelectedItem + "site:" + listBox1.SelectedItem.ToString().Substring(0, 2));
        }
    }
}
