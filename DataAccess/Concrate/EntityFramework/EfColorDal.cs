using Core.DataAccess.EntityFramework;
using DataAccess.Cocrete.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace DataAccsess.Concrate.EntityFramework;

public class EfColorDal : EfEntityRepositoryBase<Color, ReCapContext>, IColorDal
{
}