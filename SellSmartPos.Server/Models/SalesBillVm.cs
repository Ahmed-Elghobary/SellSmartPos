namespace SellSmartPos.Server.Models
{
    public class SalesBillVm
    {
        public SalesBillVm()
        {
            Details = new List<SalesBillDetailsVm>();
        }
        public int Id { get; set; }
        public int? OrderNo { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Discount { get; set; }

    
        public  List<SalesBillDetailsVm> Details { get; set; }
    }

    public class SalesBillDetailsVm
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }
    }
}
