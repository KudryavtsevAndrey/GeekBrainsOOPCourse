﻿namespace Incapsulation.Data.Entities;

public class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
