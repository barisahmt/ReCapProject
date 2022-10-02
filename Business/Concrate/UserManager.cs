using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using DataAccsess.Abstract;

namespace Business.Cocrete;

public class UserManager : IUserService
{
    private readonly IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public List<OperationClaim> GetClaims(User user)
    {
        return _userDal.GetClaim(user);
    }

    //[SecuredOperation("product.add,admin")]
    [ValidationAspect(typeof(AuthValidator))]
    public IResult Add(User user)
    {
        ValidationTool.Validate(new AuthValidator(), user);
        _userDal.Add(user);
        return new Result(true, Messages.UserAdded);
    }


    public User GetByMail(string email)
    {
        return _userDal.Get(u => u.Email == email);
    }
}