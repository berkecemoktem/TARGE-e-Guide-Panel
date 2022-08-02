using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKeywordDal : EfEntityRepositoryBase<Keyword, TargeContext>, IKeywordDal
    {
        public string AddKeyword()
        {
            return "eklendi";
        }
    }

}
