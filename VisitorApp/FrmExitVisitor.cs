using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
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

namespace VisitorApp
{
    public partial class FrmExitVisitor : Form
    {
        public FrmExitVisitor()
        {
            InitializeComponent();
        }
        private string SqlBaglantisi = @"Data Source=.;Initial Catalog=YYSVisitor;Integrated Security=True";

        private void btnList_Click(object sender, EventArgs e)
        {
        SqlConnection gridConnection = new SqlConnection(SqlBaglantisi);
        gridConnection.Open();
      


            string gridCommand = "Select name as [Adı],surname as [Soyadı],card_No as [Kart No],phone as [Telefon No],reason_for_visit as [Ziyaret Nedeni],enter_Date as [Giriş Tarihi],exit_Date as [Çıkış Tarihi],Personal_Name as [Personel Adı],Personal_Surname as [Personel Soyadı],Personal_Department as [Departmanı],Description as [Açıklama], entered_User as [Kayıt Eden], exit_User as [Çıkış Yapan] from  Tbl_Visitor  WITH(NOLOCK) where isExited not in(0) and CONVERT([date], exit_Date) >= @date1 and CONVERT([date], exit_Date) <= @date2 ORDER BY exit_Date ASC";
            SqlCommand gridCmd = new SqlCommand(gridCommand, gridConnection);
            gridCmd.Parameters.AddWithValue("@date1", dtpFilter1.Value);
            gridCmd.Parameters.AddWithValue("@date2", dtpFilter2.Value);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(gridCmd);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvExitVisitor.DataSource = dataTable;
            gridConnection.Close();
            lblTotalVisitor.Text = "Ziyaretçi Sayısı:" + "" + dgvExitVisitor.Rows.Count.ToString();
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();  
            foreach (DataGridViewColumn column in dgvExitVisitor.Columns)
            {
                column.ValueType = typeof(string);
                column.Width = 250;
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dgvExitVisitor.Rows)
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
                wb.Worksheets.Add(dt, "VisitorList");
                wb.Worksheet(1).Cells("A1:M1").Style.Fill.BackgroundColor = XLColor.FromHtml("103D8C");

                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    string cellRange = string.Format("A{0}:M{0}", i + 1);
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
                wb.SaveAs(folderPath + "Ziyaretci Listesi-" + DateTime.Now.ToString("ddMMyyyy-HHmmss") + ".xlsx");
                MessageBox.Show("Excel dosyası oluşturuldu. C:\\Excel klasöründen dosyanıza erişebilirsiniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExitVisitor_Load(object sender, EventArgs e)
        {
            ListVisitor();
        }

        public void ListVisitor()
        {
            SqlConnection gridConnection = new SqlConnection(SqlBaglantisi);
            gridConnection.Open();

            string gridCommand = "Select" +
                " [name] as [Adı]," +
                "surname as [Soyadı]," +
                "card_No as [Kart No]," +
                "phone as [Telefon No]," +
                "reason_for_visit as [Ziyaret Nedeni]" +
                ",enter_Date as [Giriş Tarihi]" +
                ",exit_Date as [Çıkış Tarihi]," +
                "Personal_Name as [Personel Adı]," +
                "Personal_Surname as [Personel Soyadı]" +
                ",Personal_Department as [Departmanı]," +
                "[Description] as [Açıklama]," +
                " entered_User as [Kayıt Eden]," +
                " exit_User as [Çıkış Yapan]" +
                " from Tbl_Visitor  WITH(NOLOCK) WHERE isExited not in(0)";
            SqlCommand gridCmd = new SqlCommand(gridCommand, gridConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(gridCmd);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvExitVisitor.DataSource = dataTable;
            gridConnection.Close();
            lblTotalVisitor.Text = "Ziyaretçi Sayısı:" + "" + dgvExitVisitor.Rows.Count.ToString();
        }

        private void dtpFilter2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvExitVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void lblTotalVisitor_Click(object sender, EventArgs e)
        {

        }
    }
}
