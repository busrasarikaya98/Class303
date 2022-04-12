using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<MailTransactionManager>().As<IMailTransactionService>();
            builder.RegisterType<MailTransactionRepository>().As<IMailTransactionRepository>();
            builder.RegisterType<VerificationCodeManager>().As<IVerificationCodeService>();
            builder.RegisterType<VerificationCodeRepository>().As<IVerificationCodeRepository>();
            builder.RegisterType<AccountRepository>().As<IAccountRepository>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions() 
                { 
                    Selector = new AspectInterceptorSelector() 
                }).SingleInstance(); 
        }
    }
}
