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
    public partial class DangnhapSV : Form
    {
        SqlConnection connSql = new SqlConnection("Data Source=NORAS\\NHANDORA;Initial Catalog=QL_TRACNGHIEM;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter adapt;

        public DangnhapSV()
        {
            InitializeComponent();
            loadForm();
        }
        public void loadForm()
        {
            lb_mssv.Text = Program.student.MSUser1;
            lb_hoten.Text = Program.student.Name1;
            lb_class.Text = Program.student.Lop1;

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            connSql.Open();
            SqlCommand kt_mssv = new SqlCommand("SELECT count(*) FROM BAITHI WHERE MaKT='"+txt_MaDe.Text+"' and MSSV = '"+Program.student.MSUser1+"'", connSql);
            int kt = (int)kt_mssv.ExecuteScalar();
            connSql.Close();
            if (kt > 0)
            {
                MessageBox.Show("Bạn đã vượt quá số lần thi !");
            }
            else {
                if (checkAccount("select * from KYTHI where MAKT = @makythi and matKhau = @passkythi"))
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Test test = new Test(txt_MaDe.Text);
                    test.Show();
                }
                else
                {
                    MessageBox.Show("MSSV or Password of Sinh Vien is Wrong!!!");
                } }
        }
        public bool checkAccount(string qr)
        {
            try
            {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand(qr, connSql);
                cmd.Parameters.AddWithValue("@makythi", txt_MaDe.Text);
                cmd.Parameters.AddWithValue("@passkythi", txt_PassDe.Text);

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

        private void txt_MaDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.IsNullOrEmpty(txt_MaDe.Text))
            {
                lb_error_made.Visible = true;
                btn_Enter.Enabled = false;
            }
            else
            {
                lb_error_made.Visible = false;
                btn_Enter.Enabled = true;
            }

            if (String.IsNullOrEmpty(txt_PassDe.Text))
            {
                lb_error_mkde.Visible = true;
                btn_Enter.Enabled = false;
            }
            else
            {
                lb_error_mkde.Visible = false;
                btn_Enter.Enabled = true;

            }
        }

        private void txt_PassDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(txt_MaDe.Text))
            {
                lb_error_made.Visible = true;
                btn_Enter.Enabled = false;
            }
            else
            {
                lb_error_made.Visible = false;
                btn_Enter.Enabled = true;
            }

            if (String.IsNullOrEmpty(txt_PassDe.Text))
            {
                lb_error_mkde.Visible = true;
                btn_Enter.Enabled = false;
            }
            else
            {
                lb_error_mkde.Visible = false;
                btn_Enter.Enabled = true;

            }
        }

        private void btn_Dangxuat_KyThi_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.student.MSUser1 = "";
            Program.student.Password1 = "";
            Program.student.Name1 = "";
            Program.student.Lop1 = "";

            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }
    }
}
