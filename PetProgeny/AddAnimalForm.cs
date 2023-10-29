using PetProgeny.Database;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PetProgeny
{
    public partial class AddAnimalForm : Form
    {
        private dbConnect dbConnect;

        public AddAnimalForm(int animalId, bool isEditMode = false)
        {
            InitializeComponent();
            dbConnect = new dbConnect("localhost", "PetProgeny");
            IsEditMode = isEditMode;

            if (IsEditMode)
            {
                Id = animalId;
                PopulateAnimalInfo(animalId);
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }


        public bool IsEditMode { get; set; }

        public int Id { get; private set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtBreed.Text) ||
        string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            DateTime dateOfBirth;

            if (!DateTime.TryParse(txtDateOfBirth.Text, out dateOfBirth))
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return;
            }

            if (!rdM.Checked && !rdF.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (ContainsNumber(txtBreed.Text) || ContainsNumber(txtType.Text))
            {
                MessageBox.Show("Breed and Type fields cannot contain numeric values.");
                return;
            }

            string name = txtName.Text;
            string type = txtType.Text;
            string breed = txtBreed.Text;
            string color = txtColor.Text;
            int parentId = int.Parse(txtParentId.Text);
            string gender = rdM.Checked ? "Male" : "Female";

            try
            {
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Animals (Name, Type, Breed, Color, DateOfBirth, Gender, ParentID) " +
                    "VALUES (@Name, @Type, @Breed, @Color, @DateOfBirth, @Gender, @ParentID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@Breed", breed);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@ParentID", parentId);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Gender", gender);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Animal data saved successfully.");                           
                        }
                        else
                        {
                            MessageBox.Show("Failed to save animal data.");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtBreed.Text) ||
        string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            DateTime dateOfBirth;

            if (!DateTime.TryParse(txtDateOfBirth.Text, out dateOfBirth))
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return;
            }

            if (!rdM.Checked && !rdF.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (ContainsNumber(txtBreed.Text) || ContainsNumber(txtType.Text))
            {
                MessageBox.Show("Breed and Type fields cannot contain numeric values.");
                return;
            }


            string name = txtName.Text;
            string type = txtType.Text;
            string breed = txtBreed.Text;
            string color = txtColor.Text;
            int parentId = int.Parse(txtParentId.Text);
            string gender = rdM.Checked ? "Male" : "Female";

            try
            {
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Animals SET Name = @Name, Breed = @Breed, Color = @Color, DateOfBirth = @DateOfBirth, Gender = @Gender, ParentID = @ParentID " +
                    "WHERE AnimalId = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@Breed", breed);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@ParentID", parentId);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Gender", gender);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Animal data updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update animal data.");
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

        private void PopulateAnimalInfo(int animalId)
        {
            try
            {
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT Name, Type, Breed, Color, ParentID, DateOfBirth, Gender FROM Animals WHERE AnimalID = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", animalId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Name"].ToString();
                                txtType.Text = reader["Type"].ToString();
                                txtBreed.Text = reader["Breed"].ToString();
                                txtColor.Text = reader["Color"].ToString();
                                txtParentId.Text = reader["ParentID"].ToString();

                                if (DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateTime dateOfBirth))
                                {
                                    txtDateOfBirth.Value = dateOfBirth;
                                }

                                string gender = reader["Gender"].ToString();
                                if (gender == "Male")
                                {
                                    rdM.Checked = true;
                                }
                                else if (gender == "Female")
                                {
                                    rdF.Checked = true;
                                }
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

        private bool ContainsNumber(string input)
        {
            return input.Any(char.IsDigit);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}