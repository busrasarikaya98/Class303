using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class MailTransactionRepository : EfBaseRepository<MailTransaction, InstagramDbContext>, IMailTransactionRepository
    {
    }
}
