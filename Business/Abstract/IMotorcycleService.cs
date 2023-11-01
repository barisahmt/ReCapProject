using Core.Utilities.Results;
using Etities.Concrate;
using Etities.Concrate.DTOs;

namespace Business.Abstract;

public interface IMotorcycleService
{
    IDataResult<List<MotorcycleDetailDto>> GetMotorcycleDetails();
    List<Motorcycle> GettAll();
    List<Motorcycle> GetByColor(string colorId);
    List<Motorcycle> GetByPrice(int min, int max);
    List<Motorcycle> GetByBrand(string brandId);
    void Add(Motorcycle entity);
    void Delete(Motorcycle entity);
    void Update(Motorcycle entity);
    
}