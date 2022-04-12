using Business.Abstract;
using Core.Abstract;
using Core.Utilities.FileOperations;
using Core.Utilities.Results;
using Core.Utilities.Tools;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    //Controller path
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;
        private IAuthService _authService;
        private IVerificationCodeService _verificationCodeService;
        public AuthController(IAuthService authService,IUserService userService,IVerificationCodeService verificationCodeService)
        {
            _authService = authService;
            _userService = userService;
            _verificationCodeService = verificationCodeService;
        }
        //EndPoint path
        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto register)
        {
            var result = _authService.Register(register);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var code = RandomCodeGenerator.Generate(6,false);
            var verificationCode = new VerificationCode()
            {
                UserId = result.Data.Id,
                Code = code,
                ExpirationDate = DateTime.Now.AddMinutes(15)
            };
            _verificationCodeService.AddAndSendMail(verificationCode, result.Data, "new-account-email","Yeni Üyelik");
            return Ok(result);
        }
        [HttpPost("activate")]
        public IActionResult Activate(UserForVerificationDto verificationDto)
        {
            var userCheck = _authService.UserVerification(verificationDto);
            if (!userCheck.Success)
            {
                return BadRequest(userCheck.Message);
            }
            var codeResult = _verificationCodeService.Get(c => c.Code == verificationDto.Code && c.ExpirationDate > DateTime.Now);
            if (codeResult.Data == null)
            {
                return BadRequest("Doğrulama kodunuz bulunamadı");
            }
            userCheck.Data.Account.IsVerification = true;
            _userService.Update(userCheck.Data);
            codeResult.Data.ExpirationDate = DateTime.Now;
            _verificationCodeService.Update(codeResult.Data);
            return Ok(new SuccessResult("Aktivasyon işlemi başarılı"));
        }
        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto loginDto)
        {
            var loginResult = _authService.Login(loginDto);
            if (!loginResult.Success)
            {
                return BadRequest(loginResult.Message);
            }
            var token = _authService.CreateAccessToken(loginResult.Data);
            return Ok(token);
        }
        [HttpPost("start-reset-password")]
        public IActionResult StartResetPassword(UserForStartResetPasswordDto resetPasswordDto)
        {
            var result=this._userService.Get(u => u.UserName == resetPasswordDto.UserName && u.Account.IsVerification);
            if (result.Data == null)
            {
                return BadRequest("Sistemde aktif olan kullanıcı bulunamadı.");
            }
            var code = RandomCodeGenerator.Generate(6, false);
            var verificationCode = new VerificationCode()
            {
                UserId = result.Data.Id,
                Code = code,
                ExpirationDate = DateTime.Now.AddMinutes(15)
            };
            _verificationCodeService.AddAndSendMail(verificationCode, result.Data, "reset-password-email", "Şifre Sıfırlama");
            var res = new SuccessDataResult<int>(result.Data.Id, "Şifre sıfırlama maili gönderildi. Lütfen mail adresinizi kontrol ediniz.");
            return Ok(res);

        }
        [HttpPost("reset-password")]
        public IActionResult ResetPassword(UserForResetPasswordDto resetPasswordDto)
        {
            var result = this._verificationCodeService.Get(c => c.Code == resetPasswordDto.Code && c.ExpirationDate > DateTime.Now);
            if (result.Data == null)
            {
                return BadRequest("Doğrulama kodunuz bulunamadı");
            }
            this._authService.ResetPassword(resetPasswordDto,result.Data.UserId);
            result.Data.ExpirationDate = DateTime.Now;
            this._verificationCodeService.Update(result.Data);
            return Ok(new SuccessResult("Şifre sıfırlama işlemi başarılı"));
        }
        [HttpGet("is-authenticated")]
        public IActionResult IsLogin()
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return Ok(false);
            }
            return Ok(true);
        }
    }
}
