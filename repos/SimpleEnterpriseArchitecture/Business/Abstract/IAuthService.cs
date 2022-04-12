using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public IDataResult<User> Login(UserForLoginDto userForLoginDto);
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        public IResult UserExists(string userName);
        public IResult ResetPassword(UserForResetPasswordDto resetPasswordDto, int userId);
        public IDataResult<User> UserVerification(UserForVerificationDto userForVerificationDto);
        public IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
