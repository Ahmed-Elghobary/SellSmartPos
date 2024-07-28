using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class Customer
    {
        public Customer()
        {
            SellsBills = new HashSet<SellsBill>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? Gender { get; set; }

        public virtual ICollection<SellsBill> SellsBills { get; set; }
    }
}
