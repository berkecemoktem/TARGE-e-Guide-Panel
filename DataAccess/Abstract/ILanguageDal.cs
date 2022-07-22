using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ILanguageDal : IEntityRepository<Language>
    {
        // Custom Operations (Only Guide Op.)
    }
}
