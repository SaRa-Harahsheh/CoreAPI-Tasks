using SaraWithArt.Server.IDataService;
using SaraWithArt.Server.Models;


namespace SaraWithArt.Server.DataService
{
    public class DataServicee : IDataServicee
    {
        private readonly MyDbContext _db;

        public DataServicee(MyDbContext db)
        {
            _db = db;
        }



        public List<Category> getCategory()
        {
            var categories = _db.Categories.ToList();

            return categories;
        }


        public Category getCategoryById(int id)
        {
            var cat = _db.Categories.Find(id);
            return cat;

        }
   

        public Category GetCategoryByName(string name)

        {
            var category = _db.Categories.Find(name);

            return category;
        }

        public Category getFirstCategory()
        {
            var category= _db.Categories.FirstOrDefault();

            return category;
        }
    }
}
