using Core.DataAccess;
using Core.Entities.Concrate;

namespace DataAccsess.Abstract;

public interface IUserDal : IEntityRepository<User>
{
    List<OperationClaim> GetClaim(User user);
}