using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStock.Models;

namespace BookStock
{
    class Database : IDisposable
    {
        private SqlConnection _SqlConnection;

        public Database(string connectionString)
        {
            string connectionStringConf = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            _SqlConnection = new SqlConnection(connectionStringConf);

        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                _SqlConnection.Open();
                string query = "Select Id, Name, Price FROM Products";
                using (SqlCommand command = new SqlCommand(query, _SqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product { 
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Name = reader["Name"].ToString(),
                                Price = Convert.ToDouble(reader["Price"].ToString())
                            };
                            products.Add(product);
                        }
                    }
                }
                _SqlConnection.Close();
            }
            catch (SqlException exp)
            {
                throw exp;
            }
            return products;
        }
        public void CreateProduct(Product product)
        {
            try
            {
                _SqlConnection.Open();
                string query = $"INSERT INTO Products (Name, Price) VALUES ('{product.Name}', {product.Price});";
                using (SqlCommand command = new SqlCommand(query, _SqlConnection))
                {
                    int affectedRow = command.ExecuteNonQuery();
                }
                _SqlConnection.Close();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                _SqlConnection.Open();
                string query = $"INSERT INTO Products (Name, Price) VALUES ('{product.Name}', {product.Price});";
                using (SqlCommand command = new SqlCommand(query, _SqlConnection))
                {
                    int affectedRow = command.ExecuteNonQuery();
                }
                _SqlConnection.Close();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        public void Dispose()
        {
            _SqlConnection.Dispose();
        }
    }
}
