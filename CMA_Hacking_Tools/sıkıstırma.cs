using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Hacking_Tools
{
    public partial class sıkıstırma : MetroForm
    {
        public sıkıstırma()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Acma(ofd.FileName, sfd.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Sıkıstırma(ofd.FileName, sfd.FileName);
            }
        }
        void Sıkıstırma(string yol, string kaydedilcekYer)
        {
            FileStream sıkıstırılcakDosya = new FileStream(yol, FileMode.Open, FileAccess.Read);
            byte[] veriler = new byte[sıkıstırılcakDosya.Length];
            sıkıstırılcakDosya.Read(veriler, 0, veriler.Length);
            sıkıstırılcakDosya.Close();
            FileStream kaydetme = new FileStream(kaydedilcekYer, FileMode.Create, FileAccess.Write);
            GZipStream sıkıstırma = new GZipStream(kaydetme, CompressionMode.Compress);
            sıkıstırma.Write(veriler, 0, veriler.Length);
            sıkıstırma.Close();
        }

        void Acma(string yol, string KaydedilcekYer)
        {
            try
            {
                FileStream sıkıstırılmısDosya = new FileStream(yol, FileMode.Open, FileAccess.Read);
                GZipStream acma = new GZipStream(sıkıstırılmısDosya, CompressionMode.Decompress);
                byte[] veriler = new byte[9999999];
                int uzunluk = acma.Read(veriler, 0, veriler.Length);
                acma.Close();
                byte[] yazilcak = new byte[uzunluk];
                Array.Copy(veriler, yazilcak, yazilcak.Length);
                FileStream kaydetme = new FileStream(KaydedilcekYer, FileMode.Create, FileAccess.Write);
                kaydetme.Write(yazilcak, 0, yazilcak.Length);
                kaydetme.Close();
            }
            catch { } 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
