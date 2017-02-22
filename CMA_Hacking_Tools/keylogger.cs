using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Hacking_Tools
{
    public partial class keylogger : MetroForm
    {
        public keylogger()
        {
            InitializeComponent();
        }
        crypto k = new crypto();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedItem .ToString () )
            {
                case "MD5":
                    richTextBox2.Text =k.MD5(t1.Text);
                    break;

                case "SHA1":
                    richTextBox2.Text = k.SHA1(t1.Text);
                    break;

                case "SHA256":
                    richTextBox2.Text = k.SHA256(t1.Text);
                    break;

                case "SHA384":
                    richTextBox2.Text = k.SHA384(t1.Text);
                    break;

                case "SHA512":
                    richTextBox2.Text = k.SHA512(t1.Text);
                    break;
                case "Sezar":
                    richTextBox2.Text = k.sezar(t1.Text);
                    break;
                default:
                    break;
            }

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            switch (metroComboBox2.SelectedItem.ToString())
            {
                case "DES":
                    richTextBox1.Text = k.DESSifrele(t2.Text);
                    break;

                case "Triple DES":
                    richTextBox1.Text = k.TripleDESSifrele(t2.Text);
                    break;

                case "RC2":
                    richTextBox1.Text = k.RC2Sifrele(t2.Text);
                    break;

                case "Rijndael":
                    richTextBox1.Text = k.RijndaelSifrele(t2.Text);
                    break;

                   default:
                    break;
            }
        }
        ArrayList liste = new ArrayList();
        private void metroButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count ; i++)
            {
                checkedListBox2.Items[i].ToString();
                switch (checkedListBox2.Items[i].ToString())
                {
                    case "MD5":
                        metroTextBox2.Text = k.MD5(metroTextBox2.Text);
                        break;

                    case "SHA1":
                        metroTextBox2.Text = k.SHA1(metroTextBox2.Text);
                        break;

                    case "SHA256":
                        metroTextBox2.Text = k.SHA256(metroTextBox2.Text);
                        break;

                    case "SHA384":
                        metroTextBox2.Text = k.SHA384(metroTextBox2.Text);
                        break;

                    case "SHA512":
                        metroTextBox2.Text = k.SHA512(metroTextBox2.Text);
                        break;
                    case "Sezar":
                        metroTextBox2.Text = k.sezar(metroTextBox2.Text);
                        break;
                    case "DES":
                        metroTextBox2.Text = k.DESSifrele(metroTextBox2.Text);
                        break;

                    case "Triple DES":
                        metroTextBox2.Text = k.TripleDESSifrele(metroTextBox2.Text);
                        break;

                    case "RC2":
                        metroTextBox2.Text = k.RC2Sifrele(metroTextBox2.Text);
                        break;

                    case "Rijndael":
                        metroTextBox2.Text = k.RijndaelSifrele(metroTextBox2.Text);
                        break;

                    default:
                        break;
                }

            }
        }
        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {
           liste.Add(checkedListBox1.SelectedItem.ToString ());
           checkedListBox2.Items.Add(checkedListBox1.SelectedItem.ToString());
        }
        private void checkedListBox2_MouseClick(object sender, MouseEventArgs e)
        {
            checkedListBox2.Items.Remove(checkedListBox2 .SelectedItem .ToString ());
        }
    }
}
