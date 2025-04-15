using SaraWithArt.Server.Models;

namespace SaraWithArt.Server.IDataService
{
    public interface IDataServicee
    {

        public List<Category> getCategory();
        
        public Category getCategoryById(int id);

        public Category GetCategoryByName(string name);

        public Category getFirstCategory();
    }
}
