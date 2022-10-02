using Core.Entities;

namespace Entities.Concrete;

public class Color : IEntity
{
    public string ColorName { get; set; }
    public int Id { get; set; }
}