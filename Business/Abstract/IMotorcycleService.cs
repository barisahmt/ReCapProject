using Etities.Concrate;

namespace Business.Abstract;

public interface IMotorcycleService
{
    List<Motorcycle> GettAll();
    List<Motorcycle> GetByColor(string colorId);
    List<Motorcycle> GetByPrice(int min, int max);
    List<Motorcycle> GetByBrand(string brandId);
    void Add(Motorcycle entity);
    void Delete(Motorcycle entity);
    void Update(Motorcycle entity);
}