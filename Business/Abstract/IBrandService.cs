using Core.Utilities.Results;
using Etities.Concrate;

namespace Business.Abstract;

public interface IBrandService
{
    IDataResult<List<Brand>> GetAll();
    IResult Add(Brand entity);

    IResult Update(Brand entity);

    IResult Delete(Brand entity);

    public IDataResult<Brand> GetByİd(int id);
    IDataResult<List<Brand>> GetByBrand(int brandId);
}