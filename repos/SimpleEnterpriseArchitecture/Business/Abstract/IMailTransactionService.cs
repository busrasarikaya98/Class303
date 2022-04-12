using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMailTransactionService
    {
        public IDataResult<List<MailTransaction>> GetAll(Expression<Func<MailTransaction, bool>> filter = null);
        public IDataResult<MailTransaction> Get(Expression<Func<MailTransaction, bool>> filter);
        public IResult Add(MailTransaction mailTransaction);

    }
}
