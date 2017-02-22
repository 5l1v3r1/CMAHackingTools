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
    public partial class google_dork_ham : MetroForm
    {
        public google_dork_ham()
        {
            InitializeComponent();
        }

        int sayac;
        private void metroButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "C.M.A Resim Seçme Kutusu";
            openFileDialog1.FileName = "Bir resim seçiniz";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader s = new StreamReader(openFileDialog1.FileName.ToString());
                string satir;
                while ((satir = s.ReadLine()) != null)
                {
                    listBox4.Items.Add(satir);
                    sayac++;
                }
                s.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox4.Items .Count ; i++)
            {
                listBox3.Items.Add("\""+"inurl:" +listBox4 .Items [i].ToString()+"\"");
            }
        }
    }
}
