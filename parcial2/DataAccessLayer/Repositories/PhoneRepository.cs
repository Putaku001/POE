using CommonLayer.Entities;
using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public class PhoneRepository
    {
        private SqlConnect _dbConnect;

        public PhoneRepository()
        {
            _dbConnect = new SqlConnect();
        }

        public List<Phone> GetPhones()
        {
            List<Phone> phonesList = new List<Phone>();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT PhoneID, Model, Brand, Price, ProviderID FROM Phones";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Phone phone = new Phone
                        {
                            PhoneID = reader.GetInt32(0),
                            Model = reader.GetString(1),
                            Brand = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            ProviderID = reader.GetInt32(4)
                        };
                        phonesList.Add(phone);
                    }
                }
            }

            return phonesList;
        }

        public void AddPhone(Phone phone)
        {
            try
            {
                using (var connection = _dbConnect.GetConnection())
                {
                    string query = "INSERT INTO Phones (Model, Brand, Price, ProviderID) VALUES (@Model, @Brand, @Price, @ProviderID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Model", phone.Model);
                    command.Parameters.AddWithValue("@Brand", phone.Brand);
                    command.Parameters.AddWithValue("@Price", phone.Price);
                    command.Parameters.AddWithValue("@ProviderID", phone.ProviderID);
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el teléfono: {ex.Message}");
            }
        }

        public void EditPhone(Phone phone)
        {
            try
            {
                using (var connection = _dbConnect.GetConnection())
                {
                    string query = "UPDATE Phones SET Model = @Model, Brand = @Brand, Price = @Price, ProviderID = @ProviderID WHERE PhoneID = @PhoneID";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@PhoneID", phone.PhoneID);
                    command.Parameters.AddWithValue("@Model", phone.Model);
                    command.Parameters.AddWithValue("@Brand", phone.Brand);
                    command.Parameters.AddWithValue("@Price", phone.Price);
                    command.Parameters.AddWithValue("@ProviderID", phone.ProviderID);
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar el teléfono: {ex.Message}");
            }
        }

        public void DeletePhone(int phoneID)
        {
            try
            {
                using (var connection = _dbConnect.GetConnection())
                {
                    string query = "DELETE FROM Phones WHERE PhoneID = @PhoneID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PhoneID", phoneID);
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el teléfono: {ex.Message}");
            }
        }
    }
}
