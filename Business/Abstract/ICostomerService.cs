using Core.Utilities.Results;
using Etities.Concrate;

namespace Business.Abstract;

public interface ICostomerService
{
    IDataResult<List<Costomer>> GetAll();

    IResult Add(Costomer entity);

    IResult Update(Costomer entity);

    IResult Delete(Costomer entity);

    IDataResult<Costomer> GetById(int id);
}