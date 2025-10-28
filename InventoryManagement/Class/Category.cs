using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Class
{
    internal class Category
    {
        private int categoryId;
        private string name;
        private string description;

        public int CategoryId
        {
            get => categoryId;
            set => categoryId = value;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Category name cannot be empty.");
                name = value;
            }
        }
        public string Description
        {
            get => description;
            set => description = value;
        }

        public Category(int id, string name, string description = "")
        {
            CategoryId = id;
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;
    }
}
