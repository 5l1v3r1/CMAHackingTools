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
    public partial class sqlmap : MetroForm
    {
        public sqlmap()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txt_query.Text != "")
            {
                saldır();
            }
            else
            {
                MessageBox.Show("Lütfen Sql Enject'li Siteyi Giriniz.", "Ayyıldız.org");
            }
        }
        private void saldır()
        {
            Process.Start(Application.StartupPath + "" + "\\" + "cmd.exe");
            SendKeys.Send("sqlmap.py -u" + " " + "\"" + txt_query.Text + "\"" + " --random-agent --dbs");
            SendKeys.Send("{enter}");
        }
        private void tablo_gtr()
        {
            Process.Start(Application.StartupPath + "" + "\\" + "Tablo_Hack.exe");
            SendKeys.Send("ssqlmap.py -u" + " " + "\"" + txt_query.Text + "\"" + " --random-agent --current-db --tables");
            SendKeys.Send("{enter}");
        }
        private void kolon_gtr()
        {
            Process.Start(Application.StartupPath + "" + "\\" + "Tablo_Hack.exe");
            SendKeys.Send("ssqlmap.py -u" + " " + "\"" + txt_query.Text + "\"" + " --random-agent --current-db -t ");
            SendKeys.Send("{enter}");
        }
        private void Tm_dtbs_gtr()
        {
            Process.Start(Application.StartupPath + "" + "\\" + "Tablo_Hack.exe");
            SendKeys.Send("ssqlmap.py -u" + " " + "\"" + txt_query.Text + "\"" + " --random-agent --dump ");
            SendKeys.Send("{enter}");
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            tablo_gtr();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            //Button fonksiyonun içerisine;

            Process p = new Process(); // Yeni nesne yarat…
            p.StartInfo.UseShellExecute = false; // Shell kullanma…
            p.StartInfo.RedirectStandardOutput = true; // Çıkışı yönlendir….
            p.StartInfo.FileName = @"C:\Python27\python.exe"; // Python klasörümüz ve derleyicimizin adı…
            p.StartInfo.Arguments = @"C:\sl\sqlmap.py";// verilecek yani çalıştırılacak python scriptimizin yolu…

            p.Start(); // işlemeye başla…

            string output = p.StandardOutput.ReadToEnd(); // çıkışı sakla
            p.WaitForExit(); // çıkış için zaman tanıyalım.         
            MessageBox.Show(output);
        }
        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            Tm_dtbs_gtr();
        }
    }
}
