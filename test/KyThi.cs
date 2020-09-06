using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace test
{
    public partial class KyThi : Form
    {
        public SqlConnection sqlcnt;
        public SqlDataAdapter adapterKyThi;
        public DataSet QL_TRACNGHIEM = new DataSet();
        public KyThi()
        {

            InitializeComponent();
            sqlcnt = new SqlConnection("Data Source=NORAS\\NHANDORA;Initial Catalog=QL_TRACNGHIEM;Integrated Security=True");

            lbl_MSSV.Text = Program.teacher.MSUser1;
            lbl_FullName.Text = Program.teacher.Name1;
            KyThi_Load();
        }


        public void KyThi_Load()
        {
            //b1
            adapterKyThi = new SqlDataAdapter("select * from KYTHI where MSGV='"+Program.teacher.MSUser1+"'", sqlcnt);
            //b2
            adapterKyThi.Fill(QL_TRACNGHIEM, "KYTHI");
            //b3
            dGv_KyThi.DataSource = QL_TRACNGHIEM.Tables["KYTHI"];


            //Tạo khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QL_TRACNGHIEM.Tables["KYTHI"].Columns[0];
            QL_TRACNGHIEM.Tables["KYTHI"].PrimaryKey = khoachinh;
        }

        private void btn_Tao_Click_1(object sender, EventArgs e)
        {

            DateTime d1 = Convert.ToDateTime(txt_TGMoDe.Text);
            DateTime d2 = Convert.ToDateTime(txt_TGDongDe.Text);
            DateTime d3 = DateTime.Now;
            

            if (d1 > d2 || d1 < d3 || d2 < d3)
            {
                MessageBox.Show("Thời gian không hợp lệ !");
            }
            else if (int.Parse(txt_ThoiGianLamBai.Text) < 15)
            {
                MessageBox.Show("Thời gian làm bài không hợp lệ");
            }
            else
            {
                //DateTime TGMoDe = 
                //b1
                if (sqlcnt.State == ConnectionState.Closed)
                {
                    sqlcnt.Open();
                }
                int count = QL_TRACNGHIEM.Tables["KYTHI"].Rows.Count + 1;
                string stringCount = count.ToString();
                if (count < 10)
                {
                    stringCount = "0" + count.ToString();
                }
                //b2
                string CauLenh = "insert into KYTHI values('KT" + stringCount + "','" + txt_PassDe.Text + "', '" + txt_TenKiThi.Text + "','"+txt_ThoiGianLamBai.Text+"', '" + Convert.ToDateTime(txt_TGMoDe.Text).ToString() + "','"
                       + Convert.ToDateTime(txt_TGDongDe.Text).ToString() + "','" + Program.teacher.MSUser1 + "')";
                //b3
                SqlCommand cmd_Khoa = new SqlCommand(CauLenh, sqlcnt);

                //b4
                cmd_Khoa.ExecuteNonQuery();
                //b5
                if (sqlcnt.State == ConnectionState.Open)
                {
                    sqlcnt.Close();
                }
                //b6
                MessageBox.Show("Thêm thành công");

                //Bước 1 Tạo DataRow
                DataRow dt_Them = QL_TRACNGHIEM.Tables["KYTHI"].NewRow();
                //Bước 2
                dt_Them["MAKT"] = "KT" + stringCount;
                dt_Them["matKhau"] = txt_PassDe.Text;
                dt_Them["tenKT"] = txt_TenKiThi.Text;
                dt_Them["thoiGianLamBai"] = txt_ThoiGianLamBai.Text;
                dt_Them["thoiGianMoDe"] = txt_TGMoDe.Text;
                dt_Them["thoiGianDongDe"] = txt_TGDongDe.Text;
                dt_Them["MSGV"] = Program.teacher.MSUser1;
                //Bước 3 Thêm row vào table Lớp
                QL_TRACNGHIEM.Tables["KYTHI"].Rows.Add(dt_Them);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dt_xoa = QL_TRACNGHIEM.Tables["KYTHI"].Rows.Find(dGv_KyThi.CurrentRow.Cells[0].Value);

            if (dt_xoa != null)
            {
                dt_xoa.Delete();

                SqlCommandBuilder sqlcm = new SqlCommandBuilder(adapterKyThi);
                adapterKyThi.Update(QL_TRACNGHIEM, "KYTHI");
                MessageBox.Show("Xóa thành công");

            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dt_sua = QL_TRACNGHIEM.Tables["KYTHI"].Rows.Find(txt_MaKiThi.Text);
                
            if (dt_sua != null)
            {
                dt_sua["MAKT"] = txt_MaKiThi.Text;
                dt_sua["matKhau"] = txt_PassDe.Text;
                dt_sua["TenKT"] = txt_TenKiThi.Text;
                dt_sua["thoiGianLamBai"] = txt_ThoiGianLamBai.Text;
                dt_sua["thoiGianMoDe"] = txt_TGMoDe.Text;
                dt_sua["thoiGianDongDe"] = txt_TGDongDe.Text;

                SqlCommandBuilder sqlcm = new SqlCommandBuilder(adapterKyThi);
                adapterKyThi.Update(QL_TRACNGHIEM, "KYTHI");
                MessageBox.Show("Sửa thành công ");
            }
                

            
        }

        private void dGv_KyThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKiThi.Text = dGv_KyThi.CurrentRow.Cells[0].Value.ToString();
            txt_PassDe.Text = dGv_KyThi.CurrentRow.Cells[1].Value.ToString();
            txt_TenKiThi.Text = dGv_KyThi.CurrentRow.Cells[2].Value.ToString();
            txt_ThoiGianLamBai.Text = dGv_KyThi.CurrentRow.Cells[3].Value.ToString();
            txt_TGMoDe.Text = dGv_KyThi.CurrentRow.Cells[4].Value.ToString();
            txt_TGDongDe.Text = dGv_KyThi.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_HTCauHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeThi dethi = new DeThi(dGv_KyThi.CurrentRow.Cells[0].Value.ToString(), dGv_KyThi.CurrentRow.Cells[2].Value.ToString(), dGv_KyThi.CurrentRow.Cells[3].Value.ToString());
            dethi.Show();
        }

        private void btn_Dangxuat_KyThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.teacher.MSUser1 = "";
            Program.teacher.Password1 = "";
            Program.teacher.Name1 = "";
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinSV thongTinSV = new ThongTinSV(dGv_KyThi.CurrentRow.Cells[0].Value.ToString(), dGv_KyThi.CurrentRow.Cells[2].Value.ToString());
            thongTinSV.Show();

        }

        private void txt_ThoiGianLamBai_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
         
        }
    }
}
