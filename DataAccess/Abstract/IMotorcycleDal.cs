using Core.DataAccess;
using Etities.Concrate;
using Etities.Concrate.DTOs;
using System.Linq.Expressions;

namespace DataAccsess.Abstract;

public interface IMotorcycleDal : IEntityRepository<Motorcycle>
{
    List<MotorcycleDetailDto> GetMotorcycleDetail(Expression<Func< Motorcycle, bool>> filter = null);
}