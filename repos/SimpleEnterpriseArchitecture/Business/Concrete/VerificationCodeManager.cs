using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.FileOperations;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class VerificationCodeManager : IVerificationCodeService
    {
        private IVerificationCodeRepository _verificationCodeRepository;
        private IMailTransactionService _mailTransactionService;

        public VerificationCodeManager(IVerificationCodeRepository verificationCodeRepository, IMailTransactionService mailTransactionService)
        {
            _verificationCodeRepository = verificationCodeRepository;
            _mailTransactionService = mailTransactionService;
        }

        public IDataResult<List<VerificationCode>> GetAll(Expression<Func<VerificationCode, bool>> filter = null)
        {
            var verificationCodes = _verificationCodeRepository.GetAll(filter);
            return new SuccessDataResult<List<VerificationCode>>(verificationCodes,"Doğrulama kodları getirildi.");
        }

        public IDataResult<VerificationCode> Get(Expression<Func<VerificationCode, bool>> filter)
        {
            var verificationCode = _verificationCodeRepository.Get(filter);
            return new SuccessDataResult<VerificationCode>(verificationCode, "Doğrulama kodu getirildi");
        }

        public IResult Add(VerificationCode verificationCode)
        {
            _verificationCodeRepository.Add(verificationCode);
            return new SuccessResult("Doğrulama kodu eklendi.");
        }
        public IResult AddAndSendMail(VerificationCode verificationCode, User user,string mailType,string subject)
        {
            this.GetAll(v => v.ExpirationDate > DateTime.Now && v.UserId == user.Id)
                .Data.ForEach(v => {
                    v.ExpirationDate = DateTime.Now;
                    _verificationCodeRepository.Update(v);
                });
            _verificationCodeRepository.Add(verificationCode);

            var content = FileOperation.ReadHtmlTemplate(mailType);
            content = content.Replace("{FullName}", user.FullName);
            content = content.Replace("{Id}", user.Id.ToString());
            content = content.Replace("{code}", verificationCode.Code);
            content = content.Replace("\\r", "");
            content = content.Replace("\\n", "");
            var mailTransaction = new MailTransaction()
            {
                UserId = user.Id,
                MailAddress = user.Account.Email,
                Subject = subject,
                Content = content,
                SendDate = DateTime.Now,
                Status = false
            };
            _mailTransactionService.Add(mailTransaction);
            return new SuccessResult("Doğrulama oluşturuldu. Mail adresinizi kontrol ediniz.");
        }
        public IResult Update(VerificationCode verificationCode)
        {
            _verificationCodeRepository.Update(verificationCode);
            return new SuccessResult("Doğrulama kodu güncellendi.");
        }

        public IResult Delete(VerificationCode verificationCode)
        {
            _verificationCodeRepository.Delete(verificationCode);
            return new SuccessResult("Doğrulama kodu silindi.");
        }
    }
}
