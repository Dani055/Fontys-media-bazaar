using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaar.logic.models;
using MediaBazaar.logic.services;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MediaBazaar.logic.services
{
    public static class InventoryService
    {
        private static MySqlConnection conn = new MySqlConnection(Utils.connectionString);
        public static List<Product> cart { get; set; } = new List<Product>();

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (conn)
            {
                string query = "SELECT * FROM Product";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = reader.GetInt32("productID");
                    string productName = reader.GetString("productName");
                    string productEAN = reader.GetString("productEan");
                    int deptID = reader.GetInt32("departmentId");
                    int amountInStock = reader.GetInt32("amountInStock");
                    int minStock = reader.GetInt32("minStock");
                    double price = reader.GetDouble("price");

                    Product p = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price);
                    products.Add(p);

                }
                reader.Close();
                conn.Close();
            }

            return products;
        }

        public static void AddNewProduct(Product newProduct)
        {
            using (conn)
            {
                string query = "INSERT INTO Product (productName,productEan,departmentId,amountInStock,minStock,price) VALUES (@productName,@productEan,@departmentId,@amountInStock,@minStock,@price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@productName", newProduct.ProductName);
                cmd.Parameters.AddWithValue("@productEan", newProduct.ProductEAN);
                cmd.Parameters.AddWithValue("@departmentId", newProduct.DepartmentID);
                cmd.Parameters.AddWithValue("@amountInStock", newProduct.AmountInStock);
                cmd.Parameters.AddWithValue("@minStock", newProduct.MinStock);
                cmd.Parameters.AddWithValue("@price", newProduct.Price);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfuly added new product");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally 
                { 
                    conn.Close(); 
                }
            }
        }

        public static void DeleteProduct (int prodID)
        {
            using (conn)
            {
                string query = "DELETE FROM Product WHERE productId = @productId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productId", prodID);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static int GetAmountInStock (int id)
        {
            string query = "select amountInStock from Product where productId = @prodId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@prodId", id);
            int result = 0;

            try
            {
                using (conn)
                {
                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static List<Product> SearchProducts(string str)
        {
            List<Product> foundProducts = new List<Product>();

            using (conn)
            {
                string query = $"SELECT * FROM Product WHERE productName LIKE '%{str}%' OR productId LIKE '%{str}%' OR productEan LIKE '%{str}%'";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = reader.GetInt32("productID");
                    string productName = reader.GetString("productName");
                    string productEAN = reader.GetString("productEan");
                    int deptID = reader.GetInt32("departmentId");
                    int amountInStock = reader.GetInt32("amountInStock");
                    int minStock = reader.GetInt32("minStock");
                    double price = reader.GetDouble("price");

                    Product p = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price);
                    foundProducts.Add(p);

                }
                reader.Close();
                conn.Close();
            }

            return foundProducts;
        }

        public static void SellProduct (int id, int sellingAmount)
        {
            int currentAmountInStock = GetAmountInStock(id);
            int newQuantity = currentAmountInStock - sellingAmount;

            if (sellingAmount > currentAmountInStock)
            {
                Utils.ShowError("One or more entries were not sold due to insufficient storage quantity");
                return;
            }

            string query = "UPDATE Product SET amountInStock = @newAmount WHERE productId = @productId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@newAmount", newQuantity.ToString());
            cmd.Parameters.AddWithValue("@productId", id.ToString());

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    Utils.ShowError("Error selling item");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
