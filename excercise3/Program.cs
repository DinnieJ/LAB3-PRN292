using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace excercise3
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
            Form1 LoginForm = new Form1();
            Application.Run(LoginForm);
            Application.Run(new Random());
        }
    }
}
