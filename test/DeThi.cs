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
    public partial class DeThi : Form
    {
        SqlConnection scnn = new SqlConnection("Data Source=NORAS\\NHANDORA;Initial Catalog=QL_TRACNGHIEM;Integrated Security=True");
        DataSet ds_DeThi = new DataSet();

        SqlDataAdapter da_DeThi;
        SqlDataAdapter da_CauHoi;
        SqlDataAdapter da_CauTraLoi;

        string makythi;
        string macauhoi="CH01";
        int thoigianlambai = 50;

        List<List<string>> listCauTraLoi = new List<List<string>>();

        public DeThi()
        {
            InitializeComponent();
        }
        public DeThi(string dethi, string tenkythi, string thoigianlambai)
        {
            this.makythi = dethi;
            this.thoigianlambai = int.Parse(thoigianlambai);

            InitializeComponent();
            Load_Form();
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;

            lbl_MSSV.Text = Program.teacher.MSUser1;
            lbl_FullName.Text = Program.teacher.Name1;
            lb_BaiThi.Text = tenkythi;
        }
        public void Load_Form()
        {
            scnn.Open();
            da_DeThi = new SqlDataAdapter("select * from FormatCTL('"+makythi+"');", scnn);
            da_DeThi.Fill(ds_DeThi, "CAUTRALOI");

            DataColumn[] primary = new DataColumn[1];
            primary[0] = ds_DeThi.Tables["CAUTRALOI"].Columns[0];
            ds_DeThi.Tables["CAUTRALOI"].PrimaryKey = primary;

            dataGridView1.DataSource = ds_DeThi.Tables["CAUTRALOI"];
            //dataGridView1.CurrentRow.In;

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
                for (int i = 1; i <= 4; i++)
                {
                    if (row[i].Equals(1))
                    {
                        listChiTiet.Add(row[0].ToString());
                        listChiTiet.Add("DA0" + i.ToString());
                    }

                }


                listCauTraLoi.Add(listChiTiet);

            }

            if (ds_DeThi.Tables["CAUHOI"].Rows.Count == 0)
            {
                da_CauTraLoi = new SqlDataAdapter("select * from CAUTRALOI where MAKT = '" + makythi + "'", scnn);
                da_CauTraLoi.Fill(ds_DeThi, "CHITIETCAUTRALOI");
            }


            Load_Detail_Question("CH01");

            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Dong.Enabled = false;
        }

        public void Load_Detail_Question(string p_MACH)
        {
            try
            {
                textCauHoi.Text = ds_DeThi.Tables["CAUHOI"].Rows.Find(new string[2] { p_MACH, makythi })[1].ToString();

                da_CauTraLoi = new SqlDataAdapter("select * from CAUTRALOI where MACH='" + p_MACH + "' AND MAKT = '" + makythi + "'", scnn);
                da_CauTraLoi.Fill(ds_DeThi, "CHITIETCAUTRALOI");

                DataColumn[] primaryCHITIETCAUTRALOI = new DataColumn[3];
                primaryCHITIETCAUTRALOI[0] = ds_DeThi.Tables["CHITIETCAUTRALOI"].Columns[0];
                primaryCHITIETCAUTRALOI[1] = ds_DeThi.Tables["CHITIETCAUTRALOI"].Columns[3];
                primaryCHITIETCAUTRALOI[2] = ds_DeThi.Tables["CHITIETCAUTRALOI"].Columns[4];
                ds_DeThi.Tables["CHITIETCAUTRALOI"].PrimaryKey = primaryCHITIETCAUTRALOI;

                
                textcaua.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] {"DA01", p_MACH, makythi })[1].ToString();
                textcaub.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA02", p_MACH, makythi })[1].ToString();
                textcauc.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA03", p_MACH, makythi })[1].ToString();
                textcaud.Text = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA04", p_MACH, makythi })[1].ToString();
            }
            catch (Exception)
            {

                return;
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                //dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
            
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataRow chooseRow = ds_DeThi.Tables["CAUHOI"].Rows.Find(dataGridView1.CurrentRow.Cells[1].Value);

            //    for (int i = 1; i <= 3; i++)
            //    {
            //        chooseRow[i] = false;
            //    }
            //    chooseRow[dataGridView1.CurrentCell.ColumnIndex] = true ;

            //}
            //catch (Exception)
            //{

            //    return;
            //}
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Dong.Enabled = true;

            DataRow dataRowCauHoi = ds_DeThi.Tables["CAUHOI"].NewRow();

            int count = ds_DeThi.Tables["CAUHOI"].Rows.Count+1;
            string stringCount = count.ToString();
            if (count < 10)
            {
                stringCount = "0" + count.ToString();
            }

            dataRowCauHoi[0] = "CH" + stringCount;
            dataRowCauHoi[1] = textCauHoi.Text;
            dataRowCauHoi[2] = makythi;
            ds_DeThi.Tables["CAUHOI"].Rows.Add(dataRowCauHoi);

            DataRow dataRowCauTraLoi = ds_DeThi.Tables["CHITIETCAUTRALOI"].NewRow();
            DataRow dataRowCauTraLoiB = ds_DeThi.Tables["CHITIETCAUTRALOI"].NewRow();
            DataRow dataRowCauTraLoiC = ds_DeThi.Tables["CHITIETCAUTRALOI"].NewRow();
            DataRow dataRowCauTraLoiD = ds_DeThi.Tables["CHITIETCAUTRALOI"].NewRow();


            dataRowCauTraLoi[0] = "DA01";
            dataRowCauTraLoi[1] = textcaua.Text;
            dataRowCauTraLoi[2] = rdoA.Checked ? 1 : 0;
            dataRowCauTraLoi[3] = "CH" + stringCount;
            dataRowCauTraLoi[4] = makythi;

            dataRowCauTraLoiB[0] = "DA02";
            dataRowCauTraLoiB[1] = textcaub.Text;
            dataRowCauTraLoiB[2] = rdoB.Checked ? 1 : 0;
            dataRowCauTraLoiB[3] = "CH" + stringCount;
            dataRowCauTraLoiB[4] = makythi;

            dataRowCauTraLoiC[0] = "DA03";
            dataRowCauTraLoiC[1] = textcauc.Text;
            dataRowCauTraLoiC[2] = rdoC.Checked ? 1 : 0;
            dataRowCauTraLoiC[3] = "CH" + stringCount;
            dataRowCauTraLoiC[4] = makythi;

            dataRowCauTraLoiD[0] = "DA04";
            dataRowCauTraLoiD[1] = textcaud.Text;
            dataRowCauTraLoiD[2] = rdoD.Checked ? 1 : 0;
            dataRowCauTraLoiD[3] = "CH" + stringCount;
            dataRowCauTraLoiD[4] = makythi;

            ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Add(dataRowCauTraLoi);
            ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Add(dataRowCauTraLoiB);
            ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Add(dataRowCauTraLoiC);
            ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Add(dataRowCauTraLoiD);

            textCauHoi.Text = "";
            textcaua.Text = "";
            textcaub.Text = "";
            textcauc.Text = "";
            textcaud.Text = "";
            MessageBox.Show("Them thanh cong");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder build = new SqlCommandBuilder(da_CauHoi);
            SqlCommandBuilder build2 = new SqlCommandBuilder(da_CauTraLoi);


            da_CauHoi.Update(ds_DeThi, "CAUHOI");
            da_CauTraLoi.Update(ds_DeThi, "CHITIETCAUTRALOI");

            MessageBox.Show("Cap nhat thanh cong");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dt_Xoa_CauHoi = ds_DeThi.Tables["CAUHOI"].Rows.Find(new string[2] { dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });

                DataRow dt_Xoa_CauTraLoi;

                dt_Xoa_CauTraLoi = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA01", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
                dt_Xoa_CauTraLoi.Delete();

                dt_Xoa_CauTraLoi = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA02", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
                dt_Xoa_CauTraLoi.Delete();

                dt_Xoa_CauTraLoi = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA03", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
                dt_Xoa_CauTraLoi.Delete();

                dt_Xoa_CauTraLoi = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA04", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
                dt_Xoa_CauTraLoi.Delete();

                MessageBox.Show("Delete Success!");
            }
            catch (Exception)
            {

                MessageBox.Show("Delete Failure!");

            }

        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            KyThi kythi = new KyThi();
            kythi.Show();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dataRowCauHoi = ds_DeThi.Tables["CAUHOI"].Rows.Find(new string[2] { dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });

            dataRowCauHoi[1] = textCauHoi.Text;

            DataRow dataRowCauTraLoi = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA01", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
            DataRow dataRowCauTraLoiB = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA02", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
            DataRow dataRowCauTraLoiC = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA03", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });
            DataRow dataRowCauTraLoiD = ds_DeThi.Tables["CHITIETCAUTRALOI"].Rows.Find(new string[3] { "DA04", dataGridView1.CurrentRow.Cells[0].Value.ToString(), makythi });

            dataRowCauTraLoi[1] = textcaua.Text;
            dataRowCauTraLoi[2] = rdoA.Checked ? 1 : 0;

            dataRowCauTraLoiB[1] = textcaub.Text;
            dataRowCauTraLoiB[2] = rdoB.Checked ? 1 : 0;

            dataRowCauTraLoiC[1] = textcauc.Text;
            dataRowCauTraLoiC[2] = rdoC.Checked ? 1 : 0;

            dataRowCauTraLoiD[1] = textcaud.Text;
            dataRowCauTraLoiD[2] = rdoD.Checked ? 1 : 0;


            textCauHoi.Text = "";
            textcaua.Text = "";
            textcaub.Text = "";
            textcauc.Text = "";
            textcaud.Text = "";
            MessageBox.Show("Edit thanh cong");

        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            List<string> listChiTiet = listCauTraLoi.Find(x => x[0].Equals(macauhoi));
            string cautraloi = "";
            if (rdoA.Checked)
            {
                cautraloi = "DA01";
            }
            else if (rdoB.Checked)
            {
                cautraloi = "DA02";
            }
            else if (rdoC.Checked)
            {
                cautraloi = "DA03";
            }
            else if (rdoD.Checked)
            {
                cautraloi = "DA04";
            }

            listChiTiet[1] = cautraloi;

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
