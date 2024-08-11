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
using System.Security.Cryptography;

namespace ASM2_DB_Winform
{
    public partial class Login : Form
    {
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-402M7NAC\\SQLEXPRESS ;Database=LibraryManagement; Integrated Security = true;");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;


            string query = "select * from Account where username = @username and u_password = @password";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["u_role"].ToString();
                if (role.Equals("staff"))
                {
                    this.Hide();
                    LibraryManagement p = new LibraryManagement();
                    p.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("reader"))
                {
                    this.Hide();
                    BookList v = new BookList();
                    v.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("manager"))
                {
                    this.Hide();
                    Manage m = new Manage();
                    m.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    lbError.Text = "You are not allowed to access";
                }
            }
            else
            {
                lbError.Text = "Wrong username or password";
            }
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
