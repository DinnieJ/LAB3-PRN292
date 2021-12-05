namespace excercise3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_vi = new System.Windows.Forms.RadioButton();
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_req_username = new System.Windows.Forms.Label();
            this.lb_req_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.llb_forgot = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_vi);
            this.groupBox1.Controls.Add(this.rb_en);
            this.groupBox1.Location = new System.Drawing.Point(276, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rb_vi
            // 
            this.rb_vi.AutoSize = true;
            this.rb_vi.Location = new System.Drawing.Point(100, 11);
            this.rb_vi.Name = "rb_vi";
            this.rb_vi.Size = new System.Drawing.Size(35, 17);
            this.rb_vi.TabIndex = 1;
            this.rb_vi.TabStop = true;
            this.rb_vi.Text = "VI";
            this.rb_vi.UseVisualStyleBackColor = true;
            this.rb_vi.CheckedChanged += new System.EventHandler(this.rb_vi_CheckedChanged);
            // 
            // rb_en
            // 
            this.rb_en.AutoSize = true;
            this.rb_en.Location = new System.Drawing.Point(7, 11);
            this.rb_en.Name = "rb_en";
            this.rb_en.Size = new System.Drawing.Size(40, 17);
            this.rb_en.TabIndex = 0;
            this.rb_en.TabStop = true;
            this.rb_en.Text = "EN";
            this.rb_en.UseVisualStyleBackColor = true;
            this.rb_en.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.Red;
            this.lb_title.Location = new System.Drawing.Point(101, 40);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(64, 20);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "LOGIN";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(13, 102);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(90, 18);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(13, 145);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(88, 18);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(159, 100);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(252, 20);
            this.tb_username.TabIndex = 4;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(159, 143);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(252, 20);
            this.tb_password.TabIndex = 5;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lb_req_username
            // 
            this.lb_req_username.AutoSize = true;
            this.lb_req_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_req_username.ForeColor = System.Drawing.Color.Red;
            this.lb_req_username.Location = new System.Drawing.Point(418, 106);
            this.lb_req_username.Name = "lb_req_username";
            this.lb_req_username.Size = new System.Drawing.Size(13, 16);
            this.lb_req_username.TabIndex = 6;
            this.lb_req_username.Text = "*";
            // 
            // lb_req_password
            // 
            this.lb_req_password.AutoSize = true;
            this.lb_req_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_req_password.ForeColor = System.Drawing.Color.Red;
            this.lb_req_password.Location = new System.Drawing.Point(417, 147);
            this.lb_req_password.Name = "lb_req_password";
            this.lb_req_password.Size = new System.Drawing.Size(13, 16);
            this.lb_req_password.TabIndex = 7;
            this.lb_req_password.Text = "*";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(16, 199);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(113, 23);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "button1";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(178, 199);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(118, 23);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "button2";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(338, 199);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "button3";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // llb_forgot
            // 
            this.llb_forgot.AutoSize = true;
            this.llb_forgot.Location = new System.Drawing.Point(202, 245);
            this.llb_forgot.Name = "llb_forgot";
            this.llb_forgot.Size = new System.Drawing.Size(55, 13);
            this.llb_forgot.TabIndex = 11;
            this.llb_forgot.TabStop = true;
            this.llb_forgot.Text = "linkLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 267);
            this.Controls.Add(this.llb_forgot);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_req_password);
            this.Controls.Add(this.lb_req_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.RadioButton rb_vi;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_req_username;
        private System.Windows.Forms.Label lb_req_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.LinkLabel llb_forgot;
    }
}

