using PetProgeny.Database;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetProgeny
{
    public partial class LoginForm : Form
    {
        private dbConnect dbConnect;

        public LoginForm()
        {
            InitializeComponent();
            dbConnect = new dbConnect("localhost", "PetProgeny");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                connection.Open();
                string query = "SELECT UserID, PasswordHash FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                            string storedHash = reader.GetString(reader.GetOrdinal("PasswordHash"));

                            bool passwordIsValid = PasswordHash.ValidatePassword(password, storedHash);

                            if (passwordIsValid)
                            {
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.ShowDialog();
        }
    }
}