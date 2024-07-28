using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellSmartPos.Server.Models;

namespace SellSmartPos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        myRestuContext db= new myRestuContext();

        [HttpGet("getAllProducts")]
        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        [HttpGet("getCustomer")]
        public List<Customer> getCustomer()
        {
            return db.Customers.ToList();
        }

        [HttpPost("saveSales")]
        public int saveSales(SalesBillVm model)
        {
            SellsBill sellsBill = new SellsBill();
            sellsBill.Cash = model.Cash;
            sellsBill.Total=model.Total;
            sellsBill.Discount=model.Discount;
            sellsBill.CustomerId = model.CustomerId;
            sellsBill.Data = DateTime.Now;
            sellsBill.OrderId = db.SellsBills.Count()==0? 1: db.SellsBills.Count() + 1;

            foreach (var item in model.Details)
            {
                sellsBill.SalelsBilDetails.Add(new SalelsBilDetail
                {
                    ProductId = item.Product.Id,
                    Price=item.Product.Price,
                    Qty=item.Qty,
                    Total=item.Total
                });
            }

            db.SellsBills.Add(sellsBill);
            return
            db.SaveChanges();
        }
    }
}
