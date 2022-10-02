using Core.DataAccess.EntityFramework;
using DataAccess.Cocrete.EntityFramework;
using DataAccsess.Abstract;
using Etities.Concrate;

namespace DataAccsess.Concrate.EntityFramework;

public class EfCarimgDal : EfEntityRepositoryBase<Carimg, ReCapContext>, ICarimgDal
{
}