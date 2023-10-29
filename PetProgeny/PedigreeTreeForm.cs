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
    public partial class PedigreeTreeForm : Form
    {
        private dbConnect dbConnect;

        public PedigreeTreeForm()
        {
            InitializeComponent();
            dbConnect = new dbConnect("localhost", "PetProgeny");
            LoadPedigreeTree();
        }

        private void LoadPedigreeTree()
        {
            try
            {
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT AnimalID, Name, ParentID FROM Animals";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int animalId = reader.GetInt32(reader.GetOrdinal("AnimalID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            int parentId = reader.IsDBNull(reader.GetOrdinal("ParentID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ParentID"));

                            TreeNode animalNode = new TreeNode(name);
                            animalNode.Tag = animalId;

                            if (parentId == 0)
                            {
                                pedigreeTreeView.Nodes.Add(animalNode);
                            }
                            else
                            {
                                TreeNode parentNode = FindNodeWithId(pedigreeTreeView.Nodes, parentId);
                                if (parentNode != null)
                                {
                                    parentNode.Nodes.Add(animalNode);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pedigree tree: " + ex.Message);
            }
        }

        private TreeNode FindNodeWithId(TreeNodeCollection nodes, int id)
        {
            foreach (TreeNode node in nodes)
            {
                if ((int)node.Tag == id)
                {
                    return node;
                }
                TreeNode foundNode = FindNodeWithId(node.Nodes, id);
                if (foundNode != null)
                {
                    return foundNode;
                }
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string animalId = txtAnimalId.Text;
            string searchCriterion = cmbSearchCriteria.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(animalId) || string.IsNullOrWhiteSpace(searchCriterion))
            {
                MessageBox.Show("Please select a search criterion and enter an Animal ID.");
                return;
            }

            pedigreeTreeView.Nodes.Clear();

            try
            {
                using (SqlConnection connection = dbConnect.GetConnection())
                {
                    connection.Open();

                    string getCriterionQuery = $"SELECT {searchCriterion} FROM Animals WHERE AnimalID = @AnimalId";
                    using (SqlCommand colorCommand = new SqlCommand(getCriterionQuery, connection))
                    {
                        colorCommand.Parameters.AddWithValue("@AnimalId", animalId);
                        string searchText = colorCommand.ExecuteScalar() as string;

                        if (string.IsNullOrWhiteSpace(searchText))
                        {
                            MessageBox.Show("Animal ID not found.");
                            return;
                        }

                        string query = $"SELECT AnimalID, Name, ParentID, DateOfBirth FROM Animals WHERE (AnimalID = @AnimalID OR ParentID = @AnimalID) AND {searchCriterion} = @SearchText";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@AnimalID", animalId);
                            command.Parameters.AddWithValue("@SearchText", searchText);
                            
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int foundAnimalId = reader.GetInt32(reader.GetOrdinal("AnimalID"));
                                    string name = reader.GetString(reader.GetOrdinal("Name"));
                                    int parentId = reader.IsDBNull(reader.GetOrdinal("ParentID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ParentID"));

                                    TreeNode animalNode = new TreeNode(name);
                                    animalNode.Tag = foundAnimalId;

                                    if (parentId == 0)
                                    {
                                        pedigreeTreeView.Nodes.Add(animalNode);
                                    }
                                    else
                                    {
                                        TreeNode parentNode = FindNodeWithId(pedigreeTreeView.Nodes, parentId);
                                        if (parentNode != null)
                                        {
                                            parentNode.Nodes.Add(animalNode);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching pedigree tree: " + ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}