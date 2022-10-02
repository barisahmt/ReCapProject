using Core.DataAccess.EntityFramework;
using Core.Entities.Concrate;
using DataAccsess.Abstract;
using DataAccsess.Concrate.EntityFramework;

namespace DataAccess.Cocrete.EntityFramework;

public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
{
    public List<OperationClaim> GetClaim(User user)
    {
        using (var context = new ReCapContext())
        {
            var result = from operationClaim in context.OperationClaims
                join userOperationClaim in context.UserOperationClaims
                    on operationClaim.Id equals userOperationClaim.OperationClaimId
                where userOperationClaim.UserId == user.Id
                select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }
    }
}