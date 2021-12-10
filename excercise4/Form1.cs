using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace excercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            using(var frmLoading = new FrmLoading())
            {
                if(frmLoading.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                this.pictureBox1.Image = (Bitmap)Properties.Resources._1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.pictureBox1.Image = (Bitmap)Properties.Resources._2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.pictureBox1.Image = (Bitmap)Properties.Resources._3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frmCalendar = new FrmCalendar())
            {
                if(frmCalendar.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }
    }
}
