using Core.Entities;

namespace Etities.Concrate;

public class Rental : IEntity
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int CarPrice { get; set; }
    public int CustomerId { get; set; }
    public int RentalHour { get; set; }
    public int CustomerAge { get; set; }
    public int CustomerMoney { get; set; }
}