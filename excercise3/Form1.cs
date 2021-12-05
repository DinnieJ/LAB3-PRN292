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
    public partial class Form1 : Form
    {
        event EventHandler LanguageChange;

        protected virtual void OnLanguageChange(EventArgs e)
        {
            EventHandler handler = LanguageChange;
            handler.Invoke(this, e);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_en.Checked)
            {
                this.lb_username.Text = "Username:";
                this.lb_password.Text = "Password:";
                this.lb_title.Text = "LOGIN";
                this.rb_en.Text = "EN";
                this.rb_vi.Text = "VI";
                this.btn_login.Text = "Login";
                this.btn_reset.Text = "Reset";
                this.btn_exit.Text = "Exit";
                this.llb_forgot.Text = "Forgot password ?";
            }
        }

        private void rb_vi_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_vi.Checked)
            {
                this.lb_username.Text = "Tên Đăng nhập:";
                this.lb_password.Text = "Mật khẩu:";
                this.lb_title.Text = "Đăng Nhập";
                this.rb_en.Text = "Anh";
                this.rb_vi.Text = "Việt";
                this.btn_login.Text = "Đăng Nhập";
                this.btn_reset.Text = "Làm mới";
                this.btn_exit.Text = "Thoát";
                this.llb_forgot.Text = "Quên Mật Khẩu ?";
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (tb_username.Text.Trim() == "") this.lb_req_username.Visible = true;
            else this.lb_req_username.Visible = false;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_password.Text.Trim() == "") this.lb_req_password.Visible = true;
            else this.lb_req_password.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == "123456" && tb_username.Text.ToLower() == "admin")
            {
                this.Hide();
                new Form2().Show();
            } else
            {
                MessageBox.Show("Wrong username or password", "Notification");
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.tb_password.Text = "";
            this.tb_username.Text = "";
        }
    }
}
