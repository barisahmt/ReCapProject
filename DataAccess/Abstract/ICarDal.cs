using System.Linq.Expressions;
using Core.DataAccess;
using Etities.Concrate;
using Etities.Concrate.DTOs;

namespace DataAccsess.Abstract;

public interface ICarDal : IEntityRepository<Car>
{
    List<CarDetailDto> GetCarDetail(Expression<Func<Car, bool>> filter = null);
}