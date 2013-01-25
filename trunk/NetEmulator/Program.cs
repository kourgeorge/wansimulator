using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetEmulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingleInstance.SingleApplication.Run(new Form1());
        }
    }
}
