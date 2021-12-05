namespace excercise3
{
    partial class Form3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.rb_PT = new System.Windows.Forms.RadioButton();
            this.rb_gcd = new System.Windows.Forms.RadioButton();
            this.rb_lcm = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_b);
            this.groupBox1.Controls.Add(this.tb_a);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cần nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_lcm);
            this.groupBox2.Controls.Add(this.rb_gcd);
            this.groupBox2.Controls.Add(this.rb_PT);
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các tùy chọn tính toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b:";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(80, 17);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(146, 20);
            this.tb_a.TabIndex = 2;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(79, 63);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(146, 20);
            this.tb_b.TabIndex = 3;
            // 
            // rb_PT
            // 
            this.rb_PT.AutoSize = true;
            this.rb_PT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_PT.Location = new System.Drawing.Point(35, 19);
            this.rb_PT.Name = "rb_PT";
            this.rb_PT.Size = new System.Drawing.Size(115, 19);
            this.rb_PT.TabIndex = 0;
            this.rb_PT.TabStop = true;
            this.rb_PT.Text = "Giải PT bậc nhất";
            this.rb_PT.UseVisualStyleBackColor = true;
            // 
            // rb_gcd
            // 
            this.rb_gcd.AutoSize = true;
            this.rb_gcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_gcd.Location = new System.Drawing.Point(35, 44);
            this.rb_gcd.Name = "rb_gcd";
            this.rb_gcd.Size = new System.Drawing.Size(131, 19);
            this.rb_gcd.TabIndex = 1;
            this.rb_gcd.TabStop = true;
            this.rb_gcd.Text = "Ước chung lớn nhất";
            this.rb_gcd.UseVisualStyleBackColor = true;
            // 
            // rb_lcm
            // 
            this.rb_lcm.AutoSize = true;
            this.rb_lcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lcm.Location = new System.Drawing.Point(35, 69);
            this.rb_lcm.Name = "rb_lcm";
            this.rb_lcm.Size = new System.Drawing.Size(131, 19);
            this.rb_lcm.TabIndex = 2;
            this.rb_lcm.TabStop = true;
            this.rb_lcm.Text = "Bội chung nhỏ nhất";
            this.rb_lcm.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(60, 147);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(198, 147);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Location = new System.Drawing.Point(341, 147);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(75, 23);
            this.btn_ext.TabIndex = 4;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_result);
            this.groupBox3.Location = new System.Drawing.Point(60, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 59);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tính toán";
            // 
            // tb_result
            // 
            this.tb_result.AutoSize = true;
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_result.Location = new System.Drawing.Point(29, 26);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(0, 16);
            this.tb_result.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 285);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_lcm;
        private System.Windows.Forms.RadioButton rb_gcd;
        private System.Windows.Forms.RadioButton rb_PT;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_ext;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tb_result;
    }
}