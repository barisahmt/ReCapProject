﻿using Core.Entities;

namespace Etities.Concrate;

public class Car : IEntity
{
    public int Id { get; set; }
    public int ColourId { get; set; }
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public int DailyPrice { get; set; }
    public string? Description { get; set; }
    public int? WeeklyPrice { get; set; }

    public int? CarPrice { get; set; }
    public int BrandId { get; set; }
    public string Location { get; set; }
}