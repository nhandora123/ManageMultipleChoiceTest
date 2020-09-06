namespace test
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_PassWord = new System.Windows.Forms.Label();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.rdb_SV = new System.Windows.Forms.RadioButton();
            this.rdb_GV = new System.Windows.Forms.RadioButton();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lb_error_mssv = new System.Windows.Forms.Label();
            this.lb_error_mk = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1003, 603);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "ĐĂNG NHẬP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_PassWord
            // 
            this.lbl_PassWord.AutoSize = true;
            this.lbl_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PassWord.ForeColor = System.Drawing.Color.White;
            this.lbl_PassWord.Location = new System.Drawing.Point(36, 199);
            this.lbl_PassWord.Name = "lbl_PassWord";
            this.lbl_PassWord.Size = new System.Drawing.Size(101, 25);
            this.lbl_PassWord.TabIndex = 0;
            this.lbl_PassWord.Text = "Mật khẩu";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV.ForeColor = System.Drawing.Color.White;
            this.lbl_MSSV.Location = new System.Drawing.Point(36, 134);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(75, 25);
            this.lbl_MSSV.TabIndex = 0;
            this.lbl_MSSV.Text = "MSSV";
            // 
            // rdb_SV
            // 
            this.rdb_SV.AutoSize = true;
            this.rdb_SV.Checked = true;
            this.rdb_SV.ForeColor = System.Drawing.Color.White;
            this.rdb_SV.Location = new System.Drawing.Point(122, 346);
            this.rdb_SV.Name = "rdb_SV";
            this.rdb_SV.Size = new System.Drawing.Size(133, 21);
            this.rdb_SV.TabIndex = 3;
            this.rdb_SV.TabStop = true;
            this.rdb_SV.Text = "Bạn là Sinh Viên";
            this.rdb_SV.UseVisualStyleBackColor = true;
            // 
            // rdb_GV
            // 
            this.rdb_GV.AutoSize = true;
            this.rdb_GV.ForeColor = System.Drawing.Color.White;
            this.rdb_GV.Location = new System.Drawing.Point(335, 346);
            this.rdb_GV.Name = "rdb_GV";
            this.rdb_GV.Size = new System.Drawing.Size(135, 21);
            this.rdb_GV.TabIndex = 3;
            this.rdb_GV.Text = "Bạn là Giáo Viên";
            this.rdb_GV.UseVisualStyleBackColor = true;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_MSSV.Location = new System.Drawing.Point(187, 134);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(283, 22);
            this.txt_MSSV.TabIndex = 0;
            this.txt_MSSV.Tag = "";
            this.txt_MSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MSSV_KeyPress);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_MatKhau.Location = new System.Drawing.Point(187, 199);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(279, 22);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MSSV_KeyPress);
            // 
            // lb_error_mssv
            // 
            this.lb_error_mssv.AutoSize = true;
            this.lb_error_mssv.ForeColor = System.Drawing.Color.Red;
            this.lb_error_mssv.Location = new System.Drawing.Point(187, 163);
            this.lb_error_mssv.Name = "lb_error_mssv";
            this.lb_error_mssv.Size = new System.Drawing.Size(173, 17);
            this.lb_error_mssv.TabIndex = 4;
            this.lb_error_mssv.Text = "*MSSV không được trống !";
            this.lb_error_mssv.Visible = false;
            // 
            // lb_error_mk
            // 
            this.lb_error_mk.AutoSize = true;
            this.lb_error_mk.ForeColor = System.Drawing.Color.Red;
            this.lb_error_mk.Location = new System.Drawing.Point(187, 234);
            this.lb_error_mk.Name = "lb_error_mk";
            this.lb_error_mk.Size = new System.Drawing.Size(193, 17);
            this.lb_error_mk.TabIndex = 4;
            this.lb_error_mk.Text = "*Mật khẩu không được trống !";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(198, 51);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(268, 46);
            this.label_Title.TabIndex = 7;
            this.label_Title.Text = "ĐĂNG NHẬP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label_Title);
            this.panel2.Controls.Add(this.lb_error_mk);
            this.panel2.Controls.Add(this.lb_error_mssv);
            this.panel2.Controls.Add(this.txt_MatKhau);
            this.panel2.Controls.Add(this.txt_MSSV);
            this.panel2.Controls.Add(this.rdb_GV);
            this.panel2.Controls.Add(this.rdb_SV);
            this.panel2.Controls.Add(this.lbl_MSSV);
            this.panel2.Controls.Add(this.lbl_PassWord);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 415);
            this.panel2.TabIndex = 7;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.Text = "DangNhapcs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_PassWord;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.RadioButton rdb_SV;
        private System.Windows.Forms.RadioButton rdb_GV;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lb_error_mssv;
        private System.Windows.Forms.Label lb_error_mk;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel2;
    }
}