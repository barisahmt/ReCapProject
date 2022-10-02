using Core.Entities;

namespace Etities.Concrate;

public class Motorcycle : IEntity
{
    public int Id { get; set; }
    public string BrandId { get; set; }
    public int ModelYear { get; set; }
    public int DailyPrice { get; set; }
    public int WeeklyPrice { get; set; }
    public int MotorPrice { get; set; }
    public string ColorId { get; set; }
    public string Location { get; set; }
    public string Model { get; set; }
    public string Description { get; set; }
}