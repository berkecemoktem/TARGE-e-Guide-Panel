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
        public List<Category> GetCategories(int languageId)
        {
           return _categoryDal.GetAllOrderByLanguage(languageId); // Get All category by QueueId.. dxfdfdg
        }

      

        public Category GetCategory(int categoryId)
        {
            return _categoryDal.Get(p => p.CategoryId == categoryId);
        }
    }

}
