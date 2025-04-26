using System;
using Microsoft.Data.SqlClient;



namespace MinecraftManager.Utils
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            _connectionString = @"Data Source=ALE_GARCIA\SQLEXPRESS;Initial Catalog=Parcial_2;Integrated Security=True;TrustServerCertificate=True";
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

        public bool TestConnection()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }
    }
}