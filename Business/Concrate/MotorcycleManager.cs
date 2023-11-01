using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;
using Etities.Concrate.DTOs;

namespace Business.Concrate;

public class MotorcycleManager : IMotorcycleService
{
    private readonly IMotorcycleDal _motorcycleDal;

    public MotorcycleManager(IMotorcycleDal motorcycleDal)
    {
        _motorcycleDal = motorcycleDal;
    }

    public void Add(Motorcycle entity)
    {
        _motorcycleDal.Add(entity);
    }

    public void Delete(Motorcycle entity)
    {
        _motorcycleDal.Delete(entity);
    }

    public List<Motorcycle> GetByBrand(string brandId)
    {
        return _motorcycleDal.GetAll(p => p.BrandId == brandId);
    }

    public List<Motorcycle> GetByColor(string colorId)
    {
        return _motorcycleDal.GetAll(p => p.ColorId == colorId);
    }

    public List<Motorcycle> GetByPrice(int min, int max)
    {
        return _motorcycleDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
    }
    

    public IDataResult<List<MotorcycleDetailDto>> GetMotorcycleDetails()
    {
        return new SuccessDataResult<List<MotorcycleDetailDto>>(_motorcycleDal.GetMotorcycleDetail(), Messages.Return);
    }

    public List<Motorcycle> GettAll()
    {
        return _motorcycleDal.GetAll();
    }


    public void Update(Motorcycle entity)
    {
        _motorcycleDal.Update(entity);
    }
}