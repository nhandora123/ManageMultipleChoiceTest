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
    public partial class ThongTinSV : Form
    {
        SqlConnection sqlcnt;
        public SqlDataAdapter adapterKyThi;
        public DataSet QL_TRACNGHIEM = new DataSet();
        string makythi;
        string tenkythi;

        public ThongTinSV(string makythi, string tenkythi)
        {
            InitializeComponent();

            lbl_MSSV.Text = Program.teacher.MSUser1;
            lbl_FullName.Text = Program.teacher.Name1;
            lb_BaiThi.Text = tenkythi;

            sqlcnt = new SqlConnection("Data Source=NORAS\\NHANDORA;Initial Catalog=QL_TRACNGHIEM;Integrated Security=True");

            this.makythi = makythi;
            this.tenkythi = tenkythi;
            KyThi_Load();

        }

        public void KyThi_Load()
        {
            //b1
            adapterKyThi = new SqlDataAdapter("select MABT, SINHVIEN.MSSV, hoTen, thoiGianBatDau, thoiGianKetThuc, diem from BAITHI, SINHVIEN where MAKT ='"+makythi+"' AND SINHVIEN.MSSV = BAITHI.MSSV", sqlcnt);
            //MessageBox.Show("select * from BAITHI where MAKT ='" + this.makythi + "'");

            adapterKyThi.Fill(QL_TRACNGHIEM, "BAITHI");
            //b3
            dataGridView1.DataSource = QL_TRACNGHIEM.Tables["BAITHI"];

            //Tạo khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QL_TRACNGHIEM.Tables["BAITHI"].Columns[0];
            QL_TRACNGHIEM.Tables["BAITHI"].PrimaryKey = khoachinh;
        }



        private void bt_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            KyThi kythi = new KyThi();
            kythi.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_mssv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lb_nameSV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (!String.IsNullOrEmpty(lb_mssv.Text))
            {
                sqlcnt.Open();
                string query = "select maLop from SinhVien where MSSV = '" + lb_mssv.Text + "'";
                SqlCommand sqlCommand1 = new SqlCommand(query, sqlcnt);

                //sqlCommand1.Parameters.AddWithValue("@makythi", makythi);
                //sqlCommand1.Parameters.AddWithValue("@mabaithi", "BT" + stringCount);

                string numberRightAnswer = sqlCommand1.ExecuteScalar().ToString();

                lb_Class.Text = numberRightAnswer;
                sqlcnt.Close();
            }

        }
    }
}
