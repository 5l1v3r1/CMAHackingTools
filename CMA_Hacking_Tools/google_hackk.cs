using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Hacking_Tools
{
    public partial class google_hackk : MetroForm
    {
        public google_hackk()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(metroTextBox1 .Text+"site:"+listBox1.SelectedItem.ToString().Substring(0,2));
        }
    }
}
