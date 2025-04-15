using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaraWithArt.Server.Models;

namespace SaraWithArt.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly MyDbContext _db;

        public ProductController(MyDbContext db)
        {
            _db = db;
        }

        [HttpGet("getProduct")]
        public IActionResult getProduct()
        {
            var product = _db.Products.ToList();
            return Ok(product);     //  “رجع للمستخدم البيانات الموجودة في product، وخلي حالة الاستجابة تكون 200 OK.”
        }



        [HttpGet("getProductById/{id}")]   //rout parameter
        public IActionResult getProductById(int id)
        {
            var Product = _db.Products.FirstOrDefault(x => x.ProductId == id);

            if (Product == null)
                return NotFound();
            return Ok(Product);
        }


        [HttpGet("getProductByName/{name}")]   //rout parameter
        public IActionResult getProductByName(string name)
        {
            var Product = _db.Products.FirstOrDefault(x => x.Name == name);

            if (Product == null)
                return NotFound();
            return Ok(Product);
        }


        [HttpGet("getFirstProduct")]   //rout parameter
        public IActionResult getFirstProduct()
        {
            var category = _db.Products.FirstOrDefault();

            if (category == null)
                return NotFound();
            return Ok(category);
        }

    }
}

