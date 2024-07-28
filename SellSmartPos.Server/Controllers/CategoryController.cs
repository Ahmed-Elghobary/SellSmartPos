using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SellSmartPos.Server.Models;

namespace SellSmartPos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        myRestuContext db = new myRestuContext();

        [HttpGet("getAllCategory")]
        public List<Category> GetAllCategory()
        {
            return db.Categories.ToList();
        }
    }
}
