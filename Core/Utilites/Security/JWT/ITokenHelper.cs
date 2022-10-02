using Core.Entities.Concrate;

namespace Core.Utilites.Security.JWT;

public interface ITokenHelper
{
    AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
}