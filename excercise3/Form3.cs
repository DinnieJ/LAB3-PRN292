using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excercise3
{
    public partial class Form3 : Form
    {
        private int CalGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            for (;;)
            {
                int remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            };
        }

        private int CalLCM(int a, int b)
        {
            return a * b / CalGCD(a, b);
        }
        public Form3()
        {
            InitializeComponent();
            this.FormClosed += Form3_FormClosed;
            this.rb_PT.Checked = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_PT.Checked) tb_result.Text = $"x = {(-(Double.Parse(tb_b.Text)) / Double.Parse(tb_a.Text))}";
                else if (rb_gcd.Checked) tb_result.Text = $"{CalGCD(Int32.Parse(tb_b.Text), Int32.Parse(tb_a.Text))}";
                else tb_result.Text = $"{CalLCM(Int32.Parse(tb_b.Text), Int32.Parse(tb_a.Text))}";

            } catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_a.Text = "";
            tb_b.Text = "";
            tb_result.Text = "";
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
