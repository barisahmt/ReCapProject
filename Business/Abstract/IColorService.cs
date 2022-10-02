using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IColorService
{
    IDataResult<List<Color>> GetAll();

    IResult Add(Color entity);

    IResult Update(Color entity);

    IResult Delete(Color entity);

    IDataResult<Color> GetById(int id);

    IDataResult<List<Color>> GetByColor(int colorId);
}