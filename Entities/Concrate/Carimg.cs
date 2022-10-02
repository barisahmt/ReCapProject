using Core.Entities;

namespace Etities.Concrate;

public class Carimg : IEntity
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public string ImagePath { get; set; }
    public DateTime Date { get; set; }
}