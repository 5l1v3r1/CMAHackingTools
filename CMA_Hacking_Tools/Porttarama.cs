using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CMA_Hacking_Tools
{
    public partial class Porttarama : MetroForm
    {
        public Porttarama()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr child, IntPtr newParent);
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);
        private const int WM_SYSCOMMAND = 274;
        private const int SC_MAXIMIZE = 61488;
        private void Porttarama_Load(object sender, EventArgs e)
        {
            string exeyolu = Application .StartupPath+""+ "\\Porttarama\\advanced_ip_scanner.exe";

            Process calistir = Process.Start(exeyolu);

            while (calistir.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(calistir.MainWindowHandle))

            {

                System.Threading.Thread.Sleep(10);

                calistir.Refresh();

            }
             calistir.WaitForInputIdle();
            SetParent(calistir.MainWindowHandle, this.panel1.Handle);
            SendMessage(calistir.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            SetWindowText(calistir.MainWindowHandle, "C.M.A Port Tarama");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string exeyolu = Application.StartupPath + "" + "\\Porttarama\\advanced_ip_scanner.exe";

            Process calistir = Process.Start(exeyolu);

            while (calistir.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(calistir.MainWindowHandle))

            {

                System.Threading.Thread.Sleep(10);

                calistir.Refresh();

            }
            calistir.WaitForInputIdle();
            SetParent(calistir.MainWindowHandle, this.panel1.Handle);
            SendMessage(calistir.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            SetWindowText(calistir.MainWindowHandle, "C.M.A Port Tarama");
        }
    }
}
