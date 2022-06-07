using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBazaarClassLibrary.models;
using MySql.Data.MySqlClient;

namespace MBazaarClassLibrary.services
{
    public static class InventoryService
    {
        private static MySqlConnection conn = new MySqlConnection(Utils.connectionString);

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (conn)
            {
                string query = "SELECT * FROM Product INNER JOIN Department on Product.departmentId = Department.departmentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = reader.GetInt32("productID");
                    string productName = reader.GetString("productName");
                    string productEAN = reader.GetString("productEan");
                    int deptID = reader.GetInt32("departmentId");
                    string deptName = reader.GetString("departmentName");
                    int amountInStock = reader.GetInt32("amountInStock");
                    int minStock = reader.GetInt32("minStock");
                    double price = reader.GetDouble("price");
                    byte[] picture = reader[7] == DBNull.Value ? null : (byte[])reader[7];

                    Product p = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price, picture) { DepartmentName = deptName};
                    products.Add(p);

                }
                reader.Close();
                conn.Close();
            }

            return products;
        }

        public static bool AddNewProduct(Product newProduct)
        {
            using (conn)
            {
                string query = "INSERT INTO Product (productName,productEan,departmentId,amountInStock,minStock,price,picture) VALUES (@productName,@productEan,@departmentId,@amountInStock,@minStock,@price,@picture)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@productName", newProduct.ProductName);
                cmd.Parameters.AddWithValue("@productEan", newProduct.ProductEAN);
                cmd.Parameters.AddWithValue("@departmentId", newProduct.DepartmentID);
                cmd.Parameters.AddWithValue("@amountInStock", newProduct.AmountInStock);
                cmd.Parameters.AddWithValue("@minStock", newProduct.MinStock);
                cmd.Parameters.AddWithValue("@price", newProduct.Price);
                cmd.Parameters.Add("@picture", MySqlDbType.MediumBlob);
                cmd.Parameters["@picture"].Value = newProduct.Picture == null ? null : newProduct.Picture;

                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool EditProduct(Product prod)
        {
            if (prod == null)
            {
                throw new Exception("No product");
            }

            string query = "UPDATE Product SET productName = @newName, productEan = @newEan, departmentId = @newDept, amountInStock = @newAmountInStock, minStock = @newMinStock, price = @newPrice, picture = @picture WHERE productId = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@newName", prod.ProductName);
            cmd.Parameters.AddWithValue("@newEan", prod.ProductEAN);
            cmd.Parameters.AddWithValue("@newDept", prod.DepartmentID);
            cmd.Parameters.AddWithValue("@newAmountInStock", prod.AmountInStock);
            cmd.Parameters.AddWithValue("@newMinStock", prod.MinStock);
            cmd.Parameters.AddWithValue("@newPrice", prod.Price);
            cmd.Parameters.AddWithValue("@id", prod.ProductID);
            cmd.Parameters.Add("@picture", MySqlDbType.MediumBlob);
            cmd.Parameters["@picture"].Value = prod.Picture == null ? null : prod.Picture;

            using (conn)
            {

                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }

        public static bool DeleteProduct(int prodID)
        {
            using (conn)
            {
                string query = "DELETE FROM Product WHERE productId = @productId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productId", prodID);

                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static int GetAmountInStock(int id)
        {
            string query = "select amountInStock from Product where productId = @prodId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@prodId", id);
            int result = 0;

            try
            {
                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            finally
            {
                conn.Close();
            }


        }

        public static List<Product> SearchProducts(string str)
        {
            List<Product> foundProducts = new List<Product>();

            using (conn)
            {
                string query = $"SELECT * FROM Product INNER JOIN Department on Product.departmentId = Department.departmentId WHERE productName LIKE @str OR productId LIKE @str OR productEan LIKE @str";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@str", "%" + str + "%");

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = reader.GetInt32("productID");
                    string productName = reader.GetString("productName");
                    string productEAN = reader.GetString("productEan");
                    int deptID = reader.GetInt32("departmentId");
                    string deptName = reader.GetString("departmentName");
                    int amountInStock = reader.GetInt32("amountInStock");
                    int minStock = reader.GetInt32("minStock");
                    double price = reader.GetDouble("price");

                    Product p = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price) { DepartmentName = deptName};
                    foundProducts.Add(p);

                }
                reader.Close();
            }

            return foundProducts;
        }

        public static Product GetProductByID(int id)
        {
            Product foundProduct = null;

            string query = $"SELECT * FROM Product WHERE productId = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
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
                    byte[] picture = reader[7] == DBNull.Value ? null : (byte[])reader[7];

                    foundProduct = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price, picture);
                }
                reader.Close();
                return foundProduct;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool SellProduct(int id, int sellingAmount, int sellerID)
        {
            int currentAmountInStock = GetAmountInStock(id);
            int newQuantity = currentAmountInStock - sellingAmount;

            if (sellingAmount > currentAmountInStock)
            {
                throw new Exception($"Entry for {sellingAmount} of item #{id} was not sold due to insufficient storage quantity");
            }

            string query = "UPDATE Product SET amountInStock = @newAmount WHERE productId = @productId;" +
                           "INSERT INTO Sale (saleDate,sellerID,productID,amount) VALUES (@saleDate,@sellerID,@productId,@amount);";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@newAmount", newQuantity.ToString());
            cmd.Parameters.AddWithValue("@productId", id.ToString());

            cmd.Parameters.AddWithValue("@saleDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@sellerID", sellerID);
            cmd.Parameters.AddWithValue("@amount", sellingAmount);

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    Product p = GetProductByID(id);
                    int newAmountInStock = p.AmountInStock;
                    int minimumStock = p.MinStock;

                    if (newAmountInStock < minimumStock)
                    {
                        int amountToRestock = (minimumStock - newAmountInStock) + minimumStock;
                        CreateRestockRequest(id, amountToRestock);
                    }
                    return true;
                }
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool RestockProduct(int id, int amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            int currentQuantity = GetAmountInStock(id);
            int newQuantity = currentQuantity + amount;

            string query = "UPDATE Product SET amountInStock = @newAmount WHERE productId = @productId";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@newAmount", newQuantity.ToString());
            cmd.Parameters.AddWithValue("@productId", id.ToString());

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool CreateRestockRequest(int productID, int amountToRestock)
        {
            string query = "INSERT INTO RestockRequest (dateCreated,productId,amount) VALUES (@dateCreated,@productId,@amount)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@dateCreated", Utils.GetDateStringForMySQL(DateTime.Now));
            cmd.Parameters.AddWithValue("@productId", productID.ToString());
            cmd.Parameters.AddWithValue("@amount", amountToRestock.ToString());

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<RestockRequest> GetRestockRequests()
        {
            List<RestockRequest> restockRequests = new List<RestockRequest>();

            using (conn)
            {
                string query = "SELECT * FROM RestockRequest inner join Product on Product.productId = RestockRequest.productId order by requestId";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = reader.GetInt32("productId");
                    string productName = reader.GetString("productName");
                    string productEAN = reader.GetString("productEan");
                    int deptID = reader.GetInt32("departmentId");
                    int amountInStock = reader.GetInt32("amountInStock");
                    int minStock = reader.GetInt32("minStock");
                    double price = reader.GetDouble("price");

                    Product p = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price);

                    int requestID = reader.GetInt32("requestId");
                    DateTime dateCreated = reader.GetDateTime("dateCreated");
                    DateTime dateProcessed;
                    if (!reader.IsDBNull(reader.GetOrdinal("dateProcessed")))
                    {
                        dateProcessed = reader.GetDateTime(reader.GetOrdinal("dateProcessed"));
                    }
                    else
                    {
                        dateProcessed = DateTime.MinValue;
                    }

                    int amountToRestock = reader.GetInt32("amount");
                    string status = reader.GetString("Status");

                    RestockRequest rr = new RestockRequest(requestID, dateCreated, dateProcessed, p, amountToRestock, status);
                    restockRequests.Add(rr);
                }
                reader.Close();
            }

            return restockRequests;
        }

        public static bool AcceptOrDenyRestockRequest(int id, bool accept)
        {
            DateTime currentDate = DateTime.Now;
            string dateString = $"{currentDate.Year}-{currentDate.Month}-{currentDate.Day}";
            string query;

            if (accept == true)
            {
                query = "UPDATE RestockRequest SET status = 'Accepted', dateProcessed = @newDate WHERE requestId = @reqId";
            }
            else
            {
                query = "UPDATE RestockRequest SET status = 'Denied', dateProcessed = @newDate WHERE requestId = @reqId";
            }

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@newDate", dateString);
            cmd.Parameters.AddWithValue("@reqId", id);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Sale> GetAllSales(SalesSort sort)
        {
            List<Sale> sales = new List<Sale>();
            string query = string.Empty;

            if (sort == SalesSort.DEFAULT)
            {
                query = "SELECT * FROM Sale inner join Employee on Sale.sellerID = Employee.id inner join Product on Sale.productID = Product.productId;";
            }
            else if (sort == SalesSort.DATEDESC)
            {
                query = "SELECT * FROM Sale inner join Employee on Sale.sellerID = Employee.id inner join Product on Sale.productID = Product.productId ORDER BY saleDate DESC;";
            } else if (sort == SalesSort.SELLERID)
            {
                query = "SELECT * FROM Sale inner join Employee on Sale.sellerID = Employee.id inner join Product on Sale.productID = Product.productId ORDER BY sellerID ASC;";
            } else if (sort == SalesSort.PRODUCTID)
            {
                query = "SELECT * FROM Sale inner join Employee on Sale.sellerID = Employee.id inner join Product on Sale.productID = Product.productId ORDER BY Sale.productID ASC;";
            }


            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //sale data
                    int saleID = reader.GetInt32("saleID");
                    DateTime saleDate = reader.GetDateTime("saleDate");
                    int amountSold = reader.GetInt32("amount");

                    //seller data
                    int empid = reader.GetInt32("id");
                    string uname = reader.GetString("username");
                    string pwd = reader.GetString("password");
                    string firstname = reader.GetString("firstName");
                    string lastname = reader.GetString("lastName");
                    string address = reader.GetString("address");
                    double wage = reader.GetDouble("hourlyWage");
                    string departmentid = reader["departmentId"].ToString();
                    string role = reader["role"].ToString();
                    string email = reader["email"].ToString();
                    string phone = reader["phone"].ToString();
                    string contractType = reader["contractType"] == DBNull.Value ? string.Empty : reader["contractType"].ToString();
                    bool isStudent = reader.GetBoolean("isStudent");
                    Employee emp = new Employee(empid, uname, pwd, firstname, lastname, wage, address, departmentid, role, email, phone, contractType) { IsStudent = isStudent };

                    //product data
                    int productID = reader.GetInt32("productID");
                    string productName = reader.GetString("productName");
                    string productEAN = reader.GetString("productEan");
                    int deptID = reader.GetInt32("departmentId");
                    int amountInStock = reader.GetInt32("amountInStock");
                    int minStock = reader.GetInt32("minStock");
                    double price = reader.GetDouble("price");

                    Product prod = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price);

                    Sale sale = new Sale(saleID, saleDate, emp, prod, amountSold);
                    sales.Add(sale);



                }
                reader.Close();
                return sales;
            } finally
            {
                conn.Close();
            }
        }
    }
}
