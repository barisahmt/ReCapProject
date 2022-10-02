using Core.Utilities.Results;
using Etities.Concrate;
using Etities.Concrate.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    IDataResult<List<CarDetailDto>> GetCarDetails();
    IDataResult<List<Car>> GettAll();
    IDataResult<List<CarDetailDto>> GetByColorId(int colorId);
    IDataResult<List<Car>> GetByPrice(int min, int max);
    IDataResult<List<CarDetailDto>> GetByBrandId(int brandId);
    IResult Add(Car car);
    IResult Delete(Car entity);
    IDataResult<Car> GetById(int carid);
}