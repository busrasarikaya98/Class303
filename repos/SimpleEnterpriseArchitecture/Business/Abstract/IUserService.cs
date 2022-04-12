using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        public IDataResult<List<User>> GetAll(Expression<Func<User, bool>> filter = null);
        public IDataResult<User> Get(Expression<Func<User, bool>> filter);
        public IResult Add(User user);
        public IResult Update(User user);
        public IResult Delete(User user);
        public List<OperationClaim> GetClaims(User user);

    }
}
