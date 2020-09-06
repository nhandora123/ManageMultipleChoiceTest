namespace test
{
    partial class DangnhapSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangnhapSV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dangxuat_KyThi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_error_made = new System.Windows.Forms.Label();
            this.lb_error_mkde = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.txt_PassDe = new System.Windows.Forms.TextBox();
            this.txt_MaDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_class = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_mssv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.pic_avatarSV = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatarSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Dangxuat_KyThi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_error_made);
            this.panel1.Controls.Add(this.lb_error_mkde);
            this.panel1.Controls.Add(this.btn_Enter);
            this.panel1.Controls.Add(this.txt_PassDe);
            this.panel1.Controls.Add(this.txt_MaDe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Title2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 508);
            this.panel1.TabIndex = 1;
            // 
            // btn_Dangxuat_KyThi
            // 
            this.btn_Dangxuat_KyThi.BackColor = System.Drawing.Color.White;
            this.btn_Dangxuat_KyThi.ForeColor = System.Drawing.Color.Black;
            this.btn_Dangxuat_KyThi.Location = new System.Drawing.Point(828, 4);
            this.btn_Dangxuat_KyThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Dangxuat_KyThi.Name = "btn_Dangxuat_KyThi";
            this.btn_Dangxuat_KyThi.Size = new System.Drawing.Size(151, 26);
            this.btn_Dangxuat_KyThi.TabIndex = 13;
            this.btn_Dangxuat_KyThi.Text = "Đăng xuất";
            this.btn_Dangxuat_KyThi.UseVisualStyleBackColor = false;
            this.btn_Dangxuat_KyThi.Click += new System.EventHandler(this.btn_Dangxuat_KyThi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(591, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 51);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Lưu ý :\r\nMã đề và mật khẩu đề của sinh viên được cấp\r\nbởi giáo viên coi thi và n" +
    "gười tạo ra đề.";
            // 
            // lb_error_made
            // 
            this.lb_error_made.AutoSize = true;
            this.lb_error_made.ForeColor = System.Drawing.Color.Red;
            this.lb_error_made.Location = new System.Drawing.Point(684, 185);
            this.lb_error_made.Name = "lb_error_made";
            this.lb_error_made.Size = new System.Drawing.Size(189, 17);
            this.lb_error_made.TabIndex = 5;
            this.lb_error_made.Text = "*Mã đề thi không được trống!";
            // 
            // lb_error_mkde
            // 
            this.lb_error_mkde.AutoSize = true;
            this.lb_error_mkde.ForeColor = System.Drawing.Color.Red;
            this.lb_error_mkde.Location = new System.Drawing.Point(684, 251);
            this.lb_error_mkde.Name = "lb_error_mkde";
            this.lb_error_mkde.Size = new System.Drawing.Size(209, 17);
            this.lb_error_mkde.TabIndex = 5;
            this.lb_error_mkde.Text = "*Mật khẩu đề không được trống!";
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Enter.Location = new System.Drawing.Point(701, 299);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(111, 57);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // txt_PassDe
            // 
            this.txt_PassDe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_PassDe.Location = new System.Drawing.Point(688, 224);
            this.txt_PassDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PassDe.Name = "txt_PassDe";
            this.txt_PassDe.PasswordChar = '*';
            this.txt_PassDe.Size = new System.Drawing.Size(193, 22);
            this.txt_PassDe.TabIndex = 3;
            this.txt_PassDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PassDe_KeyPress);
            // 
            // txt_MaDe
            // 
            this.txt_MaDe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_MaDe.Location = new System.Drawing.Point(685, 155);
            this.txt_MaDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaDe.Name = "txt_MaDe";
            this.txt_MaDe.Size = new System.Drawing.Size(193, 22);
            this.txt_MaDe.TabIndex = 3;
            this.txt_MaDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaDe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu Đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(569, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Đề Thi";
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.AutoSize = true;
            this.lbl_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Title2.Location = new System.Drawing.Point(643, 85);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(137, 38);
            this.lbl_Title2.TabIndex = 1;
            this.lbl_Title2.Text = "BÀI THI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_Title1);
            this.panel2.Controls.Add(this.pic_avatarSV);
            this.panel2.Location = new System.Drawing.Point(13, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 409);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_class);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_hoten);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_mssv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(224, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(299, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_class.Location = new System.Drawing.Point(93, 143);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(92, 24);
            this.lb_class.TabIndex = 0;
            this.lb_class.Text = "18CDTH2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoten.Location = new System.Drawing.Point(93, 94);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(194, 24);
            this.lb_hoten.TabIndex = 0;
            this.lb_hoten.Text = "Phan Trần Hiếu Nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ Tên";
            // 
            // lb_mssv
            // 
            this.lb_mssv.AutoSize = true;
            this.lb_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mssv.Location = new System.Drawing.Point(93, 46);
            this.lb_mssv.Name = "lb_mssv";
            this.lb_mssv.Size = new System.Drawing.Size(110, 24);
            this.lb_mssv.TabIndex = 0;
            this.lb_mssv.Text = "3001181729";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "MSSV";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(20, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 100);
            this.panel3.TabIndex = 5;
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.AutoSize = true;
            this.lbl_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Title1.Location = new System.Drawing.Point(67, 18);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(389, 38);
            this.lbl_Title1.TabIndex = 3;
            this.lbl_Title1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // pic_avatarSV
            // 
            this.pic_avatarSV.Image = ((System.Drawing.Image)(resources.GetObject("pic_avatarSV.Image")));
            this.pic_avatarSV.Location = new System.Drawing.Point(20, 71);
            this.pic_avatarSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_avatarSV.Name = "pic_avatarSV";
            this.pic_avatarSV.Size = new System.Drawing.Size(173, 182);
            this.pic_avatarSV.TabIndex = 0;
            this.pic_avatarSV.TabStop = false;
            // 
            // DangnhapSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 508);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangnhapSV";
            this.Text = "DangnhapSV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatarSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_error_made;
        private System.Windows.Forms.Label lb_error_mkde;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TextBox txt_PassDe;
        private System.Windows.Forms.TextBox txt_MaDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.PictureBox pic_avatarSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_mssv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Dangxuat_KyThi;
    }
}