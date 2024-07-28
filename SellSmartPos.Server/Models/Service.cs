using System;
using System.Collections.Generic;

namespace SellSmartPos.Server.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CssClass { get; set; }
    }
}
