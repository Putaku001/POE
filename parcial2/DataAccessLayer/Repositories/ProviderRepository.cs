using CommonLayer.Entities;
using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public class ProviderRepository
    {
        private SqlConnect _dbConnect;

        public ProviderRepository()
        {
            _dbConnect = new SqlConnect();
        }

        public List<Provider> GetAllProviders() 
        {
            List<Provider> providersList = new List<Provider>();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT ProviderID, Name, Phone, Email FROM Providers";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Provider provider = new Provider
                        {
                            ProviderID = reader.GetInt32(0),
                            Name = reader.GetString(1),       
                            Phone = reader.GetString(2),      
                            Email = reader.GetString(3)       
                        };
                        providersList.Add(provider);
                    }
                }
            }

            return providersList;
        }

        public void AddProvider(Provider provider)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "INSERT INTO Providers (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", provider.Name);
                command.Parameters.AddWithValue("@Phone", provider.Phone);
                command.Parameters.AddWithValue("@Email", provider.Email);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void UpdateProvider(Provider provider)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "UPDATE Providers SET Name = @Name, Phone = @Phone, Email = @Email WHERE ProviderID = @ProviderID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProviderID", provider.ProviderID);
                command.Parameters.AddWithValue("@Name", provider.Name);
                command.Parameters.AddWithValue("@Phone", provider.Phone);
                command.Parameters.AddWithValue("@Email", provider.Email);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteProvider(int providerID)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Providers WHERE ProviderID = @ProviderID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProviderID", providerID);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
