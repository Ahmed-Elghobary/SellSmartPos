using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class SalelsBilDetail
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public int? SalesBilId { get; set; }

        public virtual SellsBill? SalesBil { get; set; }
    }
}
