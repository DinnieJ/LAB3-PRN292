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
    public partial class Random : Form
    {
        List<int> a;
        bool gameStarted;
        public Random()
        {
            InitializeComponent();
            a = new List<int>();
            gameStarted = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!gameStarted)
            {
                if (numericUpDown1.Value <= 0) MessageBox.Show("Choose value > 0");
                else
                {
                    for (int i = 1; i <= numericUpDown1.Value; i++) a.Add(i);
                    a = a.OrderBy(i => Guid.NewGuid()).ToList();
                    this.lb_result.Text = $"{a.ElementAt(0)}";
                    a.RemoveAt(0);
                    gameStarted = true;
                }
            } else
            {
                if (a.Count == 0)
                {
                    MessageBox.Show("Đã hết số để chọn");
                    this.lb_result.Text = "";
                    gameStarted = false;
                }
                else
                {
                    this.lb_result.Text = $"{a.ElementAt(0)}";
                    a.RemoveAt(0);
                }
            }
        }
    }
}
