using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;

namespace DataAccess.Concrete
{
    public class AccountRepository : EfBaseRepository<Account, InstagramDbContext>, IAccountRepository
    {
    }

}
