using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class DangNhap : Form
    {
        SqlConnection connSql = new SqlConnection("Data Source=NORAS\\NHANDORA;Initial Catalog=QL_TRACNGHIEM;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter adapt;
        public DangNhap()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            txt_MSSV.Focus();
            lb_error_mssv.Visible = false;
            lb_error_mk.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb_SV.Checked)
            {
                if (checkAccount("select * from SINHVIEN where MSSV = @username and matKhau = @password"))
                {

                    Program.student.MSUser1 = ds.Tables["Account"].Rows[0][0].ToString();
                    Program.student.Password1 = ds.Tables["Account"].Rows[0][1].ToString();
                    Program.student.Name1 = ds.Tables["Account"].Rows[0][2].ToString();
                    Program.student.Lop1 = ds.Tables["Account"].Rows[0][3].ToString();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    DangnhapSV dangnhapSV = new DangnhapSV();
                    dangnhapSV.Show();
                }
                else
                {
                    MessageBox.Show("MSSV or Password of Sinh Vien is Wrong!!!");
                }
            }
            else
            {
                if (checkAccount("select * from GIAOVIEN where MSGV = @username and matKhau = @password"))
                {

                    Program.teacher.MSUser1 = ds.Tables["Account"].Rows[0][0].ToString();
                    Program.teacher.Password1 = ds.Tables["Account"].Rows[0][1].ToString();
                    Program.teacher.Name1 = ds.Tables["Account"].Rows[0][2].ToString();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    
                    KyThi kyThi = new KyThi();
                    kyThi.Show();
                }
                else
                {
                    MessageBox.Show("MSSV or Password of Giao Vien is Wrong!!!");
                }
            }

        }

        public bool checkAccount(string qr)
        {
            try
            {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand(qr, connSql);
                cmd.Parameters.AddWithValue("@username", txt_MSSV.Text);
                cmd.Parameters.AddWithValue("@password", txt_MatKhau.Text);

                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(ds, "Account");

                int count = ds.Tables["Account"].Rows.Count;

                if (count == 1)
                {
                    return true;
                }
                return false;
                //If count is equal to 1, than show frmMain form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void txt_MSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(txt_MSSV.Text))
            {
                lb_error_mssv.Visible = true;
                button1.Enabled = false;
            }
            else
            {
                lb_error_mssv.Visible = false;
                button1.Enabled = true;
            }

            if (String.IsNullOrEmpty(txt_MatKhau.Text))
            {
                lb_error_mk.Visible = true;
                button1.Enabled = false;
            }
            else
            {
                lb_error_mk.Visible = false;
                button1.Enabled = true;

            }
        }
    }
}
