using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(u => u.Account).SetValidator(new AccountValidator());
        }
    }
    public class AccountValidator : AbstractValidator<Account>
    {
        public AccountValidator()
        {
            RuleFor(a => a.Email).EmailAddress().WithMessage("Email adresinizi kontrol ediniz.");
            RuleFor(a => a.Gender).Must(gender => gender == "Erkek" || gender == "Kadın").WithMessage("Cinsiyet sadece Erkek ve Kadın olabilir.");
            RuleFor(a => a.BirthDate).LessThan(DateTime.Now.AddYears(-17)).WithMessage("Minimum 18 yaşında olmalısınız.");
        }
    }
}
