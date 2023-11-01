using Core.Entities;
using Entities.Concrate;

namespace Etities.Concrate.DTOs;

public class MotorcycleDetailDto : IDto
{
    public int MotorcycleId { get; set; }
    public string Model { get; set; }
    public string BrandName { get; set; }
    public string ColorName { get; set; }
    public int DailyPrice { get; set; }
    public int WeeklyPrice { get; set; }
    public int MotorcyclePrice { get; set; }
    public int ModelYear { get; set; }
    public List<Carimg> Carimg { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public List<Motorcycleimg> Motorcycleimgs { get; set; }
    
}