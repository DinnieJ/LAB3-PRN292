using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if(tb_name.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo");
            } else
            {
                int total = 0;

                if (cb_cv.Checked) total += 100000;
                if (cb_tt.Checked) total += 1200000;
                if (cb_chr.Checked) total += 200000;

                total += (int)nud_tr.Value * 80000;

                tb_total.Text = $"${total}";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
