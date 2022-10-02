using Core.DataAccess.EntityFramework;
using DataAccess.Cocrete.EntityFramework;
using DataAccsess.Abstract;
using Etities.Concrate;

namespace DataAccsess.Concrate.EntityFramework;

public class EfMotorcycleDal : EfEntityRepositoryBase<Motorcycle, ReCapContext>, IMotorcycleDal
{
}