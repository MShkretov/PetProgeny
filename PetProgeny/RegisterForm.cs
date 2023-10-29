using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using PetProgeny.Database;

namespace PetProgeny
{
    public partial class RegisterForm : Form
    {
        private dbConnect dbConnect;

        public RegisterForm()
        {
            InitializeComponent();
            dbConnect = new dbConnect("localhost", "PetProgeny");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string hashedPassword = PasswordHash.CreateHash(password);

            using (SqlConnection connection = dbConnect.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO Users (Username, PasswordHash, Email) VALUES (@Username, @PasswordHash, @Email)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    command.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful. You can now log in with your new account.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again later.");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}