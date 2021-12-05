using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excercise2
{
    public partial class Form1 : Form
    {
        Dictionary<string, int[]> codes = new Dictionary<string, int[]>() {
            { "Technicans", new int[] { 1645, 1689 } },
            { "Custodians", new int[] { 8345 } },
            { "Scientist", new int[] { 9998, 1006, 1007, 1008 } }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("6");
        }

        private void btn_hash_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int[]> kv in codes)
            {
                if (this.tb_code.Text != "" && kv.Value.Contains(Int32.Parse(this.tb_code.Text)))
                {
                    this.lb_log.Items.Insert(0, $"{DateTime.Now:dd/MM/yyyy HH: mm:ss}\t{kv.Key}");
                    btn_clear_Click(sender, e);
                    return;
                }
            }
            this.lb_log.Items.Insert(0, $"{DateTime.Now:dd/MM/yyyy HH: mm:ss}\tRestricted Access");
            btn_clear_Click(sender, e);

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            this.tb_code.AppendText("0");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.tb_code.Text = "";
        }
    }
}
