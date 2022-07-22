using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories(int languageId);
        Category GetCategory(int categoryId);   
    }

}
