using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Class
{
    internal class InventoryManager
    {
        private List<Product> products;
        private List<Category> categories;

        public InventoryManager()
        {
            products = new List<Product>();
            categories = new List<Category>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public List<Product> GetProducts() => products;

        public List<Category> GetCategories() => categories;

        public List<Product> GetLowStockProducts(int threshold) => products.Where(p => p.QuantityInStock <= threshold).ToList();

    }
}
