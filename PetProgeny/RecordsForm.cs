using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetProgeny.Database;

namespace PetProgeny
{
    public partial class RecordsForm : Form
    {
        private SqlConnection cn;
        private dbConnect dbConnect;
        private SqlDataReader dr;

        public RecordsForm()
        {
            InitializeComponent();
            dbConnect = new dbConnect("localhost", "PetProgeny");
            cn = new SqlConnection(dbConnect.GetConnection().ConnectionString);
            dgvAnimalList.AutoGenerateColumns = false;
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            int rowNumber = 0;
            dgvAnimalList.Rows.Clear();

            try
            {
                cn.Open();
                using (SqlCommand command = new SqlCommand("SELECT AnimalId, Name, Type, Breed, Color, DateOfBirth, Gender FROM Animals", cn))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rowNumber++;
                        int animalId = (int)reader["AnimalId"];
                        string name = reader["Name"].ToString();
                        string type = reader["Type"].ToString();
                        string breed = reader["Breed"].ToString();
                        string color = reader["Color"].ToString();
                        DateTime dateOfBirth = (DateTime)reader["DateOfBirth"];
                        string gender = reader["Gender"].ToString();

                        dgvAnimalList.Rows.Add(rowNumber, animalId, name, type, breed, color, dateOfBirth, gender);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void dgvAnimalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAnimalList.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                int animalId = Convert.ToInt32(dgvAnimalList.Rows[e.RowIndex].Cells["Id"].Value);
                AddAnimalForm addAnimalForm = new AddAnimalForm(animalId, true);


                addAnimalForm.btnSave.Enabled = false;
                addAnimalForm.btnUpdate.Enabled = true;

                addAnimalForm.ShowDialog();
                LoadAnimals();
            }
            else if (colName == "Details")
            {
                int animalId = Convert.ToInt32(dgvAnimalList.Rows[e.RowIndex].Cells["Id"].Value);
                DetailsForm detailsForm = new DetailsForm(animalId);
                detailsForm.ShowDialog();
            }
                 else if (colName == "Delete")
                {
                    int animalId = Convert.ToInt32(dgvAnimalList.Rows[e.RowIndex].Cells["Id"].Value);

                    if (MessageBox.Show("Are you sure you want to delete this animal?", "Delete Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection connection = dbConnect.GetConnection())
                            {
                                connection.Open();
                                string deleteQuery = "DELETE FROM Animals WHERE AnimalID = @animalId";

                                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@AnimalID", animalId);

                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Animal has been deleted successfully.");
                                        LoadAnimals();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to delete the animal.");
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
                }
            }

        private void addAnimalTaskButton_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm(0, false);
            addAnimalForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}