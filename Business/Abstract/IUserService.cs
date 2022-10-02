using Core.Entities.Concrate;
using Core.Utilities.Results;

namespace Business.Abstract;

public interface IUserService
{
    List<OperationClaim> GetClaims(User user);
    IResult Add(User user);
    User GetByMail(string email);
}