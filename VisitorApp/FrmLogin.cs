using System.Data;
using System.Data.SqlClient;

namespace VisitorApp
{
    public partial class FrmLogin : Form
    {
        internal object txtUsername;

        public FrmLogin()
        {
            InitializeComponent();
        }

  
        private void FrmLogin_Load(object sender, EventArgs e)
        {
   
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YASINKARACAM;Initial Catalog=YYSVisitor;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Count(*) from Tbl_User where username='" + txtUserName.Text + "' And password='" + txtPassword.Text + "'", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                FrmHome home = new FrmHome();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı. Lütfen Tekrar Deneyin");
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}