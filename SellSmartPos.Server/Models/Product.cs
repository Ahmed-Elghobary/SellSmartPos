﻿using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public string? Photo { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
