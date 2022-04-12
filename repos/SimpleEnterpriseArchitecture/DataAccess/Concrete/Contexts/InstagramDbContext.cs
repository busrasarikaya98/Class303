using Core.Utilities.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace DataAccess.Concrete.Contexts
{
    public class InstagramDbContext:DbContext
    {
        private IConfiguration Configuration;
        public InstagramDbContext()
        {
            Configuration = ServiceTool.ServiceProvider.GetService<IConfiguration>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAvatar> AccountAvatars { get; set; }
        public DbSet<PostInformation> PostInformations { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<TextMessage> TextMessages { get; set; }
        public DbSet<MailTransaction> MailTransactions { get; set; }
        public DbSet<VerificationCode> VerificationCodes { get; set; }
    }
}
