using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrate;
using Etities.Concrate;
using Etities.Concrate.DTOs;

namespace DataAccsess.Concrate.EntityFramework;

public class EfMotorcycleDal : EfEntityRepositoryBase<Motorcycle, ReCapContext>, IMotorcycleDal
{
    public List<MotorcycleDetailDto> GetMotorcycleDetail(Expression<Func<Motorcycle, bool>> filter = null)
    {
        using (var context = new ReCapContext())
        {
            var result = from mo in filter is null ? context.Motorcycles : context.Motorcycles.Where(filter)
                join c in context.Colours
                    on mo.ColorId equals c.ColorName
                join b in context.Brands
                    on mo.BrandId equals b.BrandName

                select new MotorcycleDetailDto()
                {
                    MotorcycleId = mo.Id,
                    BrandName = mo.BrandId,
                    ColorName = mo.ColorId, 
                    DailyPrice = mo.DailyPrice,
                    WeeklyPrice = mo.WeeklyPrice,
                    MotorcyclePrice = mo.MotorPrice,
                    Location = mo.Location,
                    Description = mo.Description,
                    Motorcycleimgs = (from im in context.Motorcycleimgs
                        where mo.Id == im.MotorcyleId
                        select new Motorcycleimg
                        {
                            ImagePath = im.ImagePath,
                            Id = im.Id,
                            MotorcyleId = mo.Id
                        }).ToList()


                };
            return result.ToList();
        }

        
    }
}