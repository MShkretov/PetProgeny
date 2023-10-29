using PetProgeny.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetProgeny
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dbConnect dbConnect = new dbConnect("localhost", "PetProgeny");

            try
            {
                dbConnect.CreateDatabaseIfNotExists();

                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            Application.Run(new LoginForm());
        }
    }
}
