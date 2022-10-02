using Core.Entities;

namespace Etities.Concrate;

public class Brand : IEntity
{
    public int? Id { get; set; }
    public string? BrandName { get; set; }
}