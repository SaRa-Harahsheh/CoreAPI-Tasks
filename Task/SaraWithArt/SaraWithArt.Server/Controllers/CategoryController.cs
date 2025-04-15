using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaraWithArt.Server.IDataService;
using SaraWithArt.Server.Models;

namespace SaraWithArt.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IDataServicee _data;

        public CategoryController(IDataServicee data)
        {
            _data = data;
        }


        [HttpGet("getCategory")]
        public IActionResult getCategory() 
        {
            var category = _data.getCategory();


            return Ok(category);     //  “رجع للمستخدم البيانات الموجودة في category، وخلي حالة الاستجابة تكون 200 OK.”
        }



        [HttpGet ("getCategoryById/{id}")]   //rout parameter
        public IActionResult getCategoryById(int id)
        {
            var category = _data.getCategoryById(id);

            if (category == null) 
                return NotFound();

            return Ok(category);
        }



        [HttpGet("getCategoryByName/{name}")]   //rout parameter
        public IActionResult getCategoryByName(string name)
        {
            var category = _data.GetCategoryByName(name);

            if (category == null)
                return NotFound();
            return Ok(category);
        }



        [HttpGet("getFirstCategory")]   //rout parameter
        public IActionResult getFirstCategory()
        {
            var category = _data.getFirstCategory();

            if (category == null)
                return NotFound();
            return Ok(category);
        }



        [HttpPost]
        public IActionResult addCategory([FromBody])
        {
            
        }

    }
}
