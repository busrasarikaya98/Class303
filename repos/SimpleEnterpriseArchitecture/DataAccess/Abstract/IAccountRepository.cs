using Core.DataAccess.Abstract;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
    }
}
