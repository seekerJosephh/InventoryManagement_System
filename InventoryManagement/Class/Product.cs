using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Class
{
    internal class Product
    {
        private int productId;
        private string name;
        private decimal price;
        private int quantityInStock;
        private string description;
        private Category category;

        public int ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Product name cannot be empty.");
                name = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");
                price = value;
            }
        }

        public int QuantityInStock
        {
            get => quantityInStock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative");
                quantityInStock = value;
            }
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public Category Category
        {
            get => category;
            set => category = value ?? throw new ArgumentException("category Cannot be null");

        }

        public Product(int id, string name, decimal price, int quantity, Category category, string description = "")
        {
            ProductId = id;
            Name = name;
            Price = price;
            QuantityInStock = quantity;
            Category = category;
            Description = description;
        }

        public void UpdatedStock(int quantity)
        {
            QuantityInStock += quantity;
        }

        public decimal CalculateValue() => Price * QuantityInStock;

    }
}
