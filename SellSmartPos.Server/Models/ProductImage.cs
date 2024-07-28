using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? Images { get; set; }

        public virtual Product? Product { get; set; }
    }
}
