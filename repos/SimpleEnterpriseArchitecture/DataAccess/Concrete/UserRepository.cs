using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : EfBaseRepository<User, InstagramDbContext>, IUserRepository
    {
        public override List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (var context = new InstagramDbContext())
            {
                var result = from user in context.Users
                             join account in context.Accounts
                             on user.Id equals account.UserId
                             select new User()
                             {
                                 Id = user.Id,
                                 FullName = user.FullName,
                                 PasswordHash = user.PasswordHash,
                                 PasswordSalt = user.PasswordSalt,
                                 Status = user.Status,
                                 UserName = user.UserName,
                                 Account = account
                             };
                return (filter == null) ? result.ToList() : result.Where(filter).ToList();

            }
        }
        public override User Get(Expression<Func<User, bool>> filter)
        {
            using (var context = new InstagramDbContext())
            {
                var result = from user in context.Users
                             join account in context.Accounts
                             on user.Id equals account.UserId
                             select new User()
                             {
                                 Id = user.Id,
                                 FullName = user.FullName,
                                 PasswordHash = user.PasswordHash,
                                 PasswordSalt = user.PasswordSalt,
                                 Status = user.Status,
                                 UserName = user.UserName,
                                 Account = account
                             };
                return (filter == null) ? result.SingleOrDefault() : result.Where(filter).SingleOrDefault();

            }
        }
        public override bool Add(User entity)
        {
            using (var context = new InstagramDbContext())
            {
                var addedUser = context.Entry(entity);
                addedUser.State = EntityState.Added;
                context.SaveChanges();
                if (entity.Account != null)
                {
                    entity.Account.UserId = entity.Id;
                    var addedAccount = context.Entry(entity.Account);
                    addedAccount.State = EntityState.Added;
                }
                context.SaveChanges();
                return true;

            }
        }
        public override bool Update(User entity)
        {
            using (var context = new InstagramDbContext())
            {
                var updatedUser = context.Entry(entity);
                updatedUser.State = EntityState.Modified;
                if (entity.Account != null)
                {
                    var updatedAccount = context.Entry(entity.Account);
                    updatedAccount.State = EntityState.Modified;
                }
                context.SaveChanges();
                return true;

            }
        }
        public override bool Delete(User entity)
        {
            using (var context = new InstagramDbContext())
            {
                var deletedUser = context.Entry(entity);
                deletedUser.State = EntityState.Deleted;
                if (entity.Account != null)
                {
                    var deletedAccount = context.Entry(entity.Account);
                    deletedAccount.State = EntityState.Deleted;
                }
                context.SaveChanges();
                return true;

            }
        }
        public List<OperationClaim> GetClaims(User user)
        {
            using(var context= new InstagramDbContext())
            {
                var result = from operationClaims in context.OperationClaims
                             join userOperationClaims in context.UserOperationClaims
                             on operationClaims.Id equals userOperationClaims.Id
                             where userOperationClaims.UserId == user.Id
                             select new OperationClaim() { Id = operationClaims.Id, Name = operationClaims.Name };
                return result.ToList();
            }
        }
    }
}
