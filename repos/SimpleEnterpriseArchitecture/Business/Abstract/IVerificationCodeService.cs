using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IVerificationCodeService
    {
        public IDataResult<List<VerificationCode>> GetAll(Expression<Func<VerificationCode,bool>> filter = null);
        public IDataResult<VerificationCode> Get(Expression<Func<VerificationCode,bool>> filter);
        public IResult Add(VerificationCode verificationCode);
        public IResult AddAndSendMail(VerificationCode verificationCode, User user,string mailType, string subject);
        public IResult Update(VerificationCode verificationCode);
        public IResult Delete(VerificationCode verificationCode);
    }
}
