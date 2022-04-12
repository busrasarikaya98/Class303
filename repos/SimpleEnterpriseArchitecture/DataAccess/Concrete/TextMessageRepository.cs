using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class TextMessageRepository : EfBaseRepository<TextMessage, InstagramDbContext>, ITextMessageRepository
    {
    }
}
