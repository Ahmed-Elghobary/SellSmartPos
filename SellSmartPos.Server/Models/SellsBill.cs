using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class SellsBill
    {
        public SellsBill()
        {
            SalelsBilDetails = new HashSet<SalelsBilDetail>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public int? OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? DeliverId { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Discount { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<SalelsBilDetail> SalelsBilDetails { get; set; }
    }
}
