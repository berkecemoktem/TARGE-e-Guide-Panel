using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal = new EfCategoryDal();

        public string Add(Category c)
        {
            try
            {
                _categoryDal.Add(c);
            }
            catch (System.Exception e)
            {
                return e.Message;
                throw;
            }
            return "ekleme basarili;";
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public List<Category> GetCategories(int languageId)
        {
           return _categoryDal.GetAllOrderByLanguage(languageId); // Get All category by QueueId..
        }

        public List<Category> GetCategoriesByLanguage(int LanguageId)
        {
            return _categoryDal.GetList(p => p.LanguageId == LanguageId);
        }

      

        public Category GetCategory(int categoryId)
        {
            return _categoryDal.Get(p => p.CategoryId == categoryId);
        }
    }

}
