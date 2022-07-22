using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; initial catalog = ETrade; integrated security = true");

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);


            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };

                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("INSERT INTO Products VALUES(@name, @unitPrice, @stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("UPDATE Products SET Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount WHERE Id = @Id", _connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id = @id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }


        //public DataTable GetAll2()
        //{

        //    SqlConnection connection = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; initial catalog = ETrade; integrated security = true");


        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }

        //    SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);


        //    SqlDataReader reader = command.ExecuteReader();

        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);

        //    reader.Close();
        //    connection.Close();

        //    return dataTable;

        //}
    }
}
