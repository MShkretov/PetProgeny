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
    public partial class MainForm : Form
    {
        private SqlConnection cn;
        private dbConnect dbConnection;
        private SqlDataReader dr;

        public MainForm()
        {
            InitializeComponent();
            dbConnection = new dbConnect("localhost", "PetProgeny");
            cn = new SqlConnection(dbConnection.GetConnection().ConnectionString);
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm(0, false);

            addAnimalForm.Show();
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm();

            recordsForm.Show();
        }

        private void btnPedigreeTree_Click(object sender, EventArgs e)
        {
            PedigreeTreeForm pedigreeTreeForm = new PedigreeTreeForm();

            pedigreeTreeForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
