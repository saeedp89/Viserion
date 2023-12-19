﻿namespace Viserion.Application;

public class ProductDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public DateTimeOffset ProduceDate { get; set; }
    public required string ManufactureEmail { get; set; }
    public required string ManufacturePhone { get; set; }
    public bool IsAvailable { get; set; }
    public Guid ProductOwnerId { get; set; }
}