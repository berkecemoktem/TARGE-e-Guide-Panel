using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetCategories(int languageId);
        Category GetCategory(int categoryId);
        public List<Category> GetCategoriesByLanguage(int LanguageId);
        public string Add(Category c);
    }

}
