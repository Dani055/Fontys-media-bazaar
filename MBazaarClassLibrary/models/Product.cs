using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBazaarClassLibrary.services;

namespace MBazaarClassLibrary.models
{
    public class Product : IComparable<Product>
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductEAN { get; set; }
        public int DepartmentID { get; set; }
        public int AmountInStock { get; set; }
        public int MinStock { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string ean, int deptID, int amountInStock, int minStock, double price)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.ProductEAN = ean;
            this.DepartmentID = deptID;
            this.AmountInStock = amountInStock;
            this.MinStock = minStock;
            this.Price = price;
        }

        public Product(string name, string ean, int deptID, int amountInStock, int minStock, double price)
        {
            this.ProductName = name;
            this.ProductEAN = ean;
            this.DepartmentID = deptID;
            this.AmountInStock = amountInStock;
            this.MinStock = minStock;
            this.Price = price;
        }

        public int CompareTo(Product otherProduct)
        {
            if (this.ProductID < otherProduct.ProductID)
            {
                return -1;
            }
            else if (this.ProductID > otherProduct.ProductID)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string[] GetDataArray()
        {
            string dept = DepartmentService.GetDepartmentByID(this.DepartmentID).Name;

            string[] listViewData =
            {
                ProductID.ToString(),
                ProductName,
                ProductEAN,
                dept,
                AmountInStock.ToString(),
                MinStock.ToString(),
                Price.ToString()
            };

            return listViewData;
        }
    }
}
