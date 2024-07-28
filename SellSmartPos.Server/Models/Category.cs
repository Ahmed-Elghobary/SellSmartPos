using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
