using Microsoft.VisualBasic.Logging;
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
using ClosedXML.Excel;


namespace VisitorApp
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private string SqlBaglantisi = @"Data Source=YASINKARACAM;Initial Catalog=YYSVisitor;Integrated Security=True";
        private void lblTotalVisitor_Click(object sender, EventArgs e)
        {

        }

        public void ListVisitor()
        {
            SqlConnection gridConnection = new SqlConnection(SqlBaglantisi);
            gridConnection.Open();

            

            string gridCommand = "Select Visitor_Id as [ID],[name] as [Adı],surname as [Soyadı],card_No as [Kart No],phone as [Telefon No],reason_for_visit as [Ziyaret Nedeni],enter_Date as [Giriş Tarihi],Personal_Name as [Personel Adı],Personal_Surname as [Personel Soyadı],Personal_Department as [Departmanı],[Description] as [Açıklama] ,entered_User as [Kayıt Eden] from Tbl_Visitor WHERE isExited not in(1)";
            SqlCommand gridCmd = new SqlCommand(gridCommand, gridConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(gridCmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvListVisitor.DataSource = dataTable;
            gridConnection.Close();
            lblTotalVisitor.Text = "Ziyaretçi Sayısı:" + "" + dgvListVisitor.Rows.Count.ToString();
            dgvListVisitor.Columns[0].Visible= false;
        }

        private void dgvListVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dgvListVisitor.Columns.Remove("Id");
            foreach (DataGridViewColumn column in dgvListVisitor.Columns)
            {
                column.ValueType = typeof(string);
                column.Width = 200;
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dgvListVisitor.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            { }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "ZiyaretciListesi");
                wb.Worksheet(1).Cells("A1:K1").Style.Fill.BackgroundColor = XLColor.FromHtml("103D8C");

                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    string cellRange = string.Format("A{0}:K{0}", i + 1);
                    if (i % 2 != 0)
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.White;
                    }
                    else
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.FromHtml("FAF4E4");
                    }
                }
                wb.Worksheet(1).Columns().AdjustToContents();
                wb.SaveAs(folderPath + "ZiyaretciListesi-" + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".xlsx");
                MessageBox.Show("Excel dosyası oluşturuldu. C:\\Excel klasöründen dosyanıza erişebilirsiniz.");
            }
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(SqlBaglantisi);
            connection.Open();
            string enteredUser = ((FrmLogin)Application.OpenForms.OfType<FrmLogin>().SingleOrDefault()).txtUserName.Text;


            string command = "INSERT INTO Tbl_Visitor (name,surname,card_No,phone,reason_for_visit,enter_Date,Personal_Name,Personal_Surname,Personal_Department,Description,entered_User)" +
                                                "VALUES(@name,@surname,@card_No,@phone,@reason_for_visit,@enter_Date,@Personal_Name,@Personal_Surname,@Personal_Department , @Description,@entered_User)";
            SqlCommand cmd = new SqlCommand(command, connection);

            if (txtName.Text == "" || txtSurname.Text == "" || txtCardNo.Text == "" || mskBPhone.Text == "" || cmbVisitReason.Text == "")
            {
                MessageBox.Show("Ad,Soyad,Kart Numarası, Telefon Numarası ve Ziyaret Nedeni alanları zorunludur.");
            }
            else
            {
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@card_No", txtCardNo.Text);
                cmd.Parameters.AddWithValue("@phone", mskBPhone.Text.ToString());
                cmd.Parameters.AddWithValue("@reason_for_visit", cmbVisitReason.Text);
                cmd.Parameters.AddWithValue("@enter_Date", dtpEnterDate.Value);
                cmd.Parameters.AddWithValue("@Personal_Name", txtPersonalName.Text);
                cmd.Parameters.AddWithValue("@Personal_Surname", txtPersonalSurname.Text);
                cmd.Parameters.AddWithValue("@Personal_Department", txtPersonalDepartment.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@entered_User", enteredUser);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
                ListVisitor();

                //Form Clear
                txtName.Clear();
                txtSurname.Clear();
                txtCardNo.Clear();
                mskBPhone.Clear();
                cmbVisitReason.ResetText();
                txtPersonalName.Clear();
                txtPersonalSurname.Clear();
                txtPersonalDepartment.Clear();
                txtDescription.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

         
           
                ;
                int id = Convert.ToInt32(dgvListVisitor.SelectedRows[0].Cells[0].Value);

                SqlConnection connection = new SqlConnection(SqlBaglantisi);
                connection.Open();
            string enteredUser = ((FrmLogin)Application.OpenForms.OfType<FrmLogin>().SingleOrDefault()).txtUserName.Text;
            string exitUser = ((FrmLogin)Application.OpenForms.OfType<FrmLogin>().SingleOrDefault()).txtUserName.Text;

            string command = "Update Tbl_Visitor set isExited = 1,exit_Date = getDate(), exit_User='"+enteredUser+"' where Visitor_Id = @Visitor_Id ";
                SqlCommand cmd = new SqlCommand(command, connection);


                cmd.Parameters.AddWithValue("@Visitor_Id", id);
                cmd.Parameters.AddWithValue("@exit_User", exitUser);
                cmd.ExecuteNonQuery();
                connection.Close();
                ListVisitor();
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FrmExitVisitor frmExitVisitor = new FrmExitVisitor();   
            frmExitVisitor.ShowDialog();
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
          Application.Exit();
        } 

        private void FrmHome_Load(object sender, EventArgs e)
        {
            ListVisitor();

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YASINKARACAM;Initial Catalog=YYSVisitor;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select Reason From Tbl_Reason";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbVisitReason.Items.Add(dr["Reason"]);
            }
            baglanti.Close();
        }

        private void cmbVisitReason_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mskBPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskBPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvListVisitor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCardNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)  && !char.IsSeparator(e.KeyChar);
        }
    }
}
