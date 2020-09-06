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
    public partial class Test : Form
    {
        string makythi;
        string macauhoi="CH01";
        SqlConnection scnn;
        SqlDataAdapter adapterKyThi;
        DataSet QL_TRACNGHIEM = new DataSet();


        DataSet ds_DeThi = new DataSet();
        SqlDataAdapter da_DeThi;
        SqlDataAdapter da_CauHoi;
        SqlDataAdapter da_CauTraLoi;
        SqlDataAdapter da_BaiThi;

        DateTime timeStart = DateTime.Now;
        DateTime timeEnd;
        private int minutes=60;
        private int seconds = 1;

        List<List<string>> listCauTraLoi = new List<List<string>>();
        
        public Test(string p_MaKT)
        {
            InitializeComponent();
            scnn = new SqlConnection("Data Source=NORAS\\NHANDORA;Initial Catalog=QL_TRACNGHIEM;Integrated Security=True");
            this.makythi = p_MaKT;
            loadForm();
            Load_Time();

        }
        public void loadForm()
        {
            lbl_MSSV.Text = Program.student.MSUser1;
            lbl_FullName.Text = Program.student.Name1;
            lbl_Class.Text = Program.student.Lop1;

            adapterKyThi = new SqlDataAdapter("select * from KYTHI where MaKT='" + makythi + "'", scnn);

            adapterKyThi.Fill(QL_TRACNGHIEM, "KYTHI");
            //Tạo khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QL_TRACNGHIEM.Tables["KYTHI"].Columns[0];
            QL_TRACNGHIEM.Tables["KYTHI"].PrimaryKey = khoachinh;

            lb_BaiThi.Text = "Bài thi " + QL_TRACNGHIEM.Tables["KYTHI"].Rows[0][2].ToString();
            lb_mabaithi.Text = "BT01";
            lbl_ThoiGian.Text = QL_TRACNGHIEM.Tables["KYTHI"].Rows[0][3].ToString()+ ":00";

            this.minutes =int.Parse( QL_TRACNGHIEM.Tables["KYTHI"].Rows[0][3].ToString());

            Load_Form_CauHoi();
        }
        public void Load_Form_CauHoi()
        {

            da_DeThi = new SqlDataAdapter("select * from FormatCTL('" + makythi + "');", scnn);
            da_DeThi.Fill(ds_DeThi, "CAUTRALOI");
            foreach (DataRow row in ds_DeThi.Tables["CAUTRALOI"].Rows)
            {
                for (int i = 1; i <= 4; i++)
                {
                    row[i] = 0;
                }

            }

            DataColumn[] primary = new DataColumn[1];
            primary[0] = ds_DeThi.Tables["CAUTRALOI"].Columns[0];
            ds_DeThi.Tables["CAUTRALOI"].PrimaryKey = primary;

            dataGridView1.DataSource = ds_DeThi.Tables["CAUTRALOI"];

            //LoadCauHoi
            da_CauHoi = new SqlDataAdapter("select * from CAUHOI where MAKT = '" + makythi + "'", scnn);
            da_CauHoi.Fill(ds_DeThi, "CAUHOI");

            DataColumn[] primaryCauHoi = new DataColumn[2];
            primaryCauHoi[0] = ds_DeThi.Tables["CAUHOI"].Columns[0];
            primaryCauHoi[1] = ds_DeThi.Tables["CAUHOI"].Columns[2];
            ds_DeThi.Tables["CAUHOI"].PrimaryKey = primaryCauHoi;

            foreach (DataRow row in ds_DeThi.Tables["CAUTRALOI"].Rows)
            {
                List<string> listChiTiet = new List<string>();
                listChiTiet.Add(row[0].ToString());
                listChiTiet.Add("null");

                listCauTraLoi.Add(listChiTiet);
                
            }

            if (ds_DeThi.Tables["CAUHOI"].Rows.Count == 0)
            {
                da_CauTraLoi = new SqlDataAdapter("select * from CAUTRALOI where MAKT = '" + makythi + "'", scnn);
                da_CauTraLoi.Fill(ds_DeThi, "CHITIETCAUTRALOI");
            }

            Load_Detail_Question("CH01");

        }

        public void Load_Detail_Question(string p_MACH)
        {
            try
            {
                lbl_CauHoi.Text = ds_DeThi.Tables["CAUHOI"].Rows.Find(new string[2] { p_MACH, makythi })[1].ToString();

                da_CauTraLoi = new SqlDataAdapter("select * from CAUTRALOI where MACH='" + p_MACH + "' AND MAKT = '" + makythi + "'", scnn);
                da_CauTraLoi.Fill(ds_DeThi, "CHITIETCAUTRALOI");

                DataColumn[] primaryCHITIETCAUTRALOI = new DataColumn[3];
                primaryCHITIETCAUTRALOI[0] = ds_DeThi.Tables["CHITIETCAUTRALOI"].Columns[0];
                primaryCHITIETCAUTRALOI[1] = ds_DeThi.Tables["CHITIETCAUTRALOI"].Columns[3];
                primaryCHITIETCAUTRALOI[2] = ds_DeThi.Tables["CHITIETCAUTRALOI"].Columns[4];
                ds_DeThi.Tables["CHITIETCAUTRALOI"].PrimaryKey = primaryCHITIETCAUTRALOI;

                lbl_CauA.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA01", p_MACH, makythi })[1].ToString();
                lbl_CauB.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA02", p_MACH, makythi })[1].ToString();
                lbl_CauC.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA03", p_MACH, makythi })[1].ToString();
                lbl_CauD.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA04", p_MACH, makythi })[1].ToString();
                

            }
            catch (Exception)
            {

                return;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Detail_Question(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            macauhoi = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (!String.IsNullOrEmpty(macauhoi))
            {

                List<string> listChiTiet = listCauTraLoi.Find(x => x[0].Equals(macauhoi));

                if (listChiTiet[1].Equals("DA01"))
                {
                    rdoA.Checked = true;
                }
                else if (listChiTiet[1].Equals("DA02"))
                {
                    rdoB.Checked = true;
                }
                else if (listChiTiet[1].Equals("DA03"))
                {
                    rdoC.Checked = true;
                }
                else if (listChiTiet[1].Equals("DA04"))
                {
                    rdoD.Checked = true;
                }
                else
                {
                    rdoA.Checked = false;
                    rdoB.Checked = false;
                    rdoC.Checked = false;
                    rdoD.Checked = false;
                }
            }
            
        }


        Timer timer1;
        private void Load_Time()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if(seconds == 0)
            {
                seconds = 59;
                minutes--;
            }
            if (minutes == 0 && seconds == 0)
            {
                timer1.Stop();
                updateBaiThi();
                MessageBox.Show("Hết giờ !!!");
                LogOut();
            }

            lbl_ThoiGian.Text = minutes.ToString()+ ":" +seconds.ToString();
        }
        private void LogOut()
        {
            Program.student.MSUser1 = "";
            Program.student.Password1 = "";
            Program.student.Name1 = "";
            Program.student.Lop1 = "";

            this.Hide();
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }
        private void btn_Nop_Click(object sender, EventArgs e)
        {
            if (listCauTraLoi.FindAll(x => x[1] == "null").Count > 0)
            {
                MessageBox.Show("Không được để trống đáp án!");
            }
            else
            {

                string message = "Bạn có thực sự muốn nộp bài?";
                string title = "Nộp bài";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    updateBaiThi();
                    timer1.Stop();
                    LogOut();
                }
                else
                {
                    // Do something  
                }
            }
        }
        public void updateBaiThi()
        {
            timeEnd = DateTime.Now;
            da_BaiThi = new SqlDataAdapter("select * from BaiThi", scnn);
            da_BaiThi.Fill(ds_DeThi, "BAITHI");

            int count = ds_DeThi.Tables["BAITHI"].Rows.Count +1;
            string stringCount = count.ToString();
            if (count < 10)
            {
                stringCount = "0" + count.ToString();
            }
            scnn.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into BAITHI values (@maBaiThi, @mssv, @maKT, @timeStart, @timeEnd, @tiendo, @diem)", scnn);
            sqlCommand.Parameters.AddWithValue("@maBaiThi", "BT" + stringCount);
            sqlCommand.Parameters.AddWithValue("@mssv", Program.student.MSUser1);
            sqlCommand.Parameters.AddWithValue("@maKT", makythi);
            sqlCommand.Parameters.AddWithValue("@timeStart", timeStart.ToString());
            sqlCommand.Parameters.AddWithValue("@timeEnd", timeEnd.ToString());
            sqlCommand.Parameters.AddWithValue("@tiendo", "80");
            sqlCommand.Parameters.AddWithValue("@diem", "0");

            //MessageBox.Show(timeStart.ToString());
            sqlCommand.ExecuteNonQuery();
            

            foreach  (List<string> detail in listCauTraLoi)
            {
                updateChiTietBaiThi(stringCount, detail[1], detail[0], makythi);

            }

            int numberRightAnswer = countNumberRightAnswer(stringCount);
            int numberAllAnswer = countNumberAllAnswer();
            double score = (double) numberRightAnswer / numberAllAnswer * 10;
            updateScore("BT"+stringCount, score);
            scnn.Close();
            MessageBox.Show("Số điểm của bạn là "+score.ToString());

        }
        public int countNumberRightAnswer(string stringCount)
        {
            string query = "select count(*) from CHITIETBAITHI, CAUTRALOI where MABT ='"+ "BT" + stringCount + "' and CAUTRALOI.MAKT = '"+makythi+"' and CHITIETBAITHI.MACH = CAUTRALOI.MACH and CHITIETBAITHI.MACTL = CAUTRALOI.MACTL and dapAn =1 ";
            SqlCommand sqlCommand1 = new SqlCommand(query, scnn);

            //sqlCommand1.Parameters.AddWithValue("@makythi", makythi);
            //sqlCommand1.Parameters.AddWithValue("@mabaithi", "BT" + stringCount);

            int numberRightAnswer = (int)sqlCommand1.ExecuteScalar();
            return numberRightAnswer;
        }
        public int countNumberAllAnswer()
        {
            SqlCommand sqlCommand2 = new SqlCommand("select count(*) from CAUHOI where MAKT = @makythi", scnn);
            sqlCommand2.Parameters.AddWithValue("@makythi", makythi);

            int numberAllAnswer = (int)sqlCommand2.ExecuteScalar();
            return numberAllAnswer;
        }

        public void updateScore(string p_mabt, double p_score)
        {
            string query = "update BAITHI SET diem = "+p_score.ToString()+" WHERE MABT = '"+p_mabt+"'";
            SqlCommand sqlCommand1 = new SqlCommand(query, scnn);
            int numberLine= sqlCommand1.ExecuteNonQuery();
        }
        public void updateChiTietBaiThi(string p_maBT, string p_maCTL, string p_maCH, string p_maKT)
        {
            da_BaiThi = new SqlDataAdapter("select * from ChiTietBaiThi", scnn);
            da_BaiThi.Fill(ds_DeThi, "CHITIETBAITHI");

            int count1 = ds_DeThi.Tables["CHITIETBAITHI"].Rows.Count + 1;
            string stringCount1 = count1.ToString();
            if (count1 < 10)
            {
                stringCount1 = "0" + count1.ToString();
            }
            SqlCommand sqlCommand = new SqlCommand("insert into CHITIETBAITHI values (@maChiTiet, @tenBaiThi, @maBT, @maCTL, @maCH, @maKT)", scnn);
            sqlCommand.Parameters.AddWithValue("@maChiTiet", "CT" + stringCount1);
            sqlCommand.Parameters.AddWithValue("@tenBaiThi", "Bài Thi Trắc Nghiệm");
            sqlCommand.Parameters.AddWithValue("@maBT", "BT"+ p_maBT);
            sqlCommand.Parameters.AddWithValue("@maCTL", p_maCTL);
            sqlCommand.Parameters.AddWithValue("@maCH", p_maCH);
            sqlCommand.Parameters.AddWithValue("@maKT", p_maKT);

            //MessageBox.Show(timeStart.ToString());
            sqlCommand.ExecuteNonQuery();

            ds_DeThi.Tables["CHITIETBAITHI"].Clear();

        }
        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            //List<string> listChiTiet = new List<string>();
            List<string> listChiTiet = listCauTraLoi.Find(x => x[0].Equals(macauhoi));
            string cautraloi = "";
            if (rdoA.Checked)
            {
                cautraloi = "DA01";
            }else if (rdoB.Checked)
            {
                cautraloi = "DA02";
            }else if (rdoC.Checked)
            {
                cautraloi = "DA03";
            }else if (rdoD.Checked)
            {
                cautraloi = "DA04";
            }

            listChiTiet[1]=cautraloi;

            foreach (DataRow row in ds_DeThi.Tables["CAUTRALOI"].Rows)
            {
                if (row[0].ToString().Equals(macauhoi))
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        row[i] = false;
                    }
                    if (rdoA.Checked)
                    {
                        row[1] = true;
                    }
                    else if (rdoB.Checked)
                    {
                        row[2] = true;
                    }
                    else if (rdoC.Checked)
                    {
                        row[3] = true;
                    }
                    else if (rdoD.Checked)
                    {
                        row[4] = true;
                    }

                }
            }
        }



    }
}
