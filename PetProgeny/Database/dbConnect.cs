using System;
using System.Data.SqlClient;

namespace PetProgeny.Database
{
    public class dbConnect
    {
        private readonly string serverName;
        private readonly string dbName;
        private readonly string connectionString;

        public dbConnect(string serverName, string dbName)
        {
            this.serverName = serverName;
            this.dbName = dbName;
            connectionString = $"Data Source={serverName};Initial Catalog={dbName};Integrated Security=True";
        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public void CreateDatabaseIfNotExists()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT database_id FROM sys.databases WHERE Name = '{dbName}'";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            string createDatabaseQuery = $"CREATE DATABASE {dbName}";
                            using (SqlCommand createCmd = new SqlCommand(createDatabaseQuery, connection))
                            {
                                createCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating/checking the database: " + ex.Message);
            }
        }
    }
}