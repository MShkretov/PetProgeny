using PetProgeny.Database;
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

namespace PetProgeny
{
    public partial class DetailsForm : Form
    {
        private dbConnect dbConnect;
        private int Id;

        public DetailsForm(int id)
        {
            InitializeComponent();
            dbConnect = new dbConnect("localhost", "PetProgeny");
            Id = id;
            LoadAnimalDetails();
            SetFieldsReadOnly(true);
        }

        private void LoadAnimalDetails()
        {
            try
            {
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT Name, Type, Breed, Color, DateOfBirth, Gender FROM Animals WHERE AnimalID = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Name"].ToString();
                                txtType.Text = reader["Type"].ToString();
                                txtBreed.Text = reader["Breed"].ToString();
                                txtColor.Text = reader["Color"].ToString();
                                txtDateOfBirth.Text = reader["DateOfBirth"].ToString();

                                string gender = reader["Gender"].ToString();
                                rdM.Checked = gender.Equals("Male", StringComparison.OrdinalIgnoreCase);
                                rdF.Checked = gender.Equals("Female", StringComparison.OrdinalIgnoreCase);
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            txtName.ReadOnly = readOnly;
            txtType.ReadOnly = readOnly;
            txtBreed.ReadOnly = readOnly;
            txtColor.ReadOnly = readOnly;
            txtDateOfBirth.Enabled = !readOnly;
            rdM.Enabled = !readOnly;
            rdF.Enabled = !readOnly;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}