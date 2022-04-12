using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(e => e.UserName).NotEmpty().NotNull().NotEqual("string");
            RuleFor(e => e.Email).EmailAddress().WithMessage("Email adresinizi kontrol ediniz.");
            RuleFor(e => e.FullName).NotEmpty().NotNull();
            RuleFor(e => e.Gender).Must(gender => gender == "Erkek" || gender == "Kadın").WithMessage("Cinsiyet sadece Erkek ve Kadın olabilir.");
            RuleFor(e => e.BirthDate).LessThan(DateTime.Now.AddYears(-17)).WithMessage("Minimum 18 yaşında olmalısınız.");
            RuleFor(e => e.Password).Equal(password => password.RePassword).WithMessage("Şifre ve tekrar şifresi eşit olmalıdır. ");
        }
    }
    public class ResetPasswordValidator : AbstractValidator<UserForResetPasswordDto>
    {
        public ResetPasswordValidator()
        {
            RuleFor(e => e.Code).NotEmpty().NotNull();
            RuleFor(e => e.Password).Equal(password => password.RePassword).WithMessage("Şifre ve tekrar şifresi eşit olmalıdır. ");
        }
    }
}
