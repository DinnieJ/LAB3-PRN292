using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excercise4
{
    public partial class FrmCalendar : Form
    {
        private readonly string[] Chi = new string[] {
            "Thân",
            "Dậu",
            "Tuất",
            "Hợi",
            "Tý",
            "Sửu",
            "Dần",
            "Mão",
            "Thìn",
            "Tỵ",
            "Ngọ",
            "Mùi"
        };

        private readonly string[] Can = new string[]
        {
            "Canh",
            "Tân",
            "Nhâm",
            "Quý",
            "Giáp",
            "Ất",
            "Bình",
            "Đinh",
            "Mậu",
            "Kỷ"
        };

        public FrmCalendar()
        {
            InitializeComponent();
            this.FormClosing += FrmCalendar_FormClosing;
        }

        private void FrmCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Int32.Parse(textBox1.Text);
                var V_Chi = year % 12;
                var V_Can = year % 10;
                textBox2.Text = $"{Can[V_Can]} {Chi[V_Chi]}";
            } catch
            {
                MessageBox.Show("Invalid year input");
            }
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
