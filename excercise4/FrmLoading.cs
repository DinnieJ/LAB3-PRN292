using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace excercise4
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
            Shown += FrmLoading_Load;
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Application loading...";
            while (true)
            {
                Console.WriteLine(progressBar1.Value);
                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    break;
                }
                else {
                    progressBar1.Value += 10;
                    Thread.Sleep(500);
                };

            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
