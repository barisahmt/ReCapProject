using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Chasing;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;
using Etities.Concrate.DTOs;

namespace Business.Concrate;

public class CarManager : ICarService
{
    private readonly ICarDal _cardal;

    public CarManager(ICarDal cardal)
    {
        _cardal = cardal;
    }

    //[SecuredOperation("admin")]
    //[ValidationAspect(typeof(CarValidator))]
    //[CacheRemoveAspect("ICarService.Get")]
    //[PerformanceAspect(5)]
    public IResult Add(Car car)
    {
        ValidationTool.Validate(new CarValidator(), car);
        _cardal.Add(car);
        return new Result(true, Messages.CarAdded);
    }

    public IResult Delete(Car car)
    {
        _cardal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
    }

    [CacheAspect(25)]
    public IDataResult<List<CarDetailDto>> GetByBrandId(int brandId)
    {
        return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetail(c => c.BrandId == brandId));
    }

    public IDataResult<List<CarDetailDto>> GetByColorId(int colorId)
    {
        return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetail(c => c.Id == colorId));
    }

    public IDataResult<Car> GetById(int carid)
    {
        return new SuccessDataResult<Car>(_cardal.Get(c => c.Id == carid));
    }

    public IDataResult<List<Car>> GetByPrice(int min, int max)
    {
        return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetail(),Messages.CarsListed);
    }
    public IDataResult<List<Car>> GettAll()
    {
        //if (DateTime.Now.Hour == 1)
        //return new ErrorDataResult<List<Car>>(Messages.MainteanceTime);
        return new SuccessDataResult<List<Car>>(_cardal.GetAll(), Messages.CarsListed);
    }
}