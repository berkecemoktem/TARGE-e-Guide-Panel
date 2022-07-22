using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TargeContext>, ICategoryDal
    {
        public List<Category> GetAllOrderByLanguage(int languageId)
        {
            using (TargeContext context = new TargeContext())
            {
               return context.Categories.OrderBy(p=> p.QueueNo).Where(p => p.LanguageId == languageId).ToList();
                 
            }
        }
    }

}
