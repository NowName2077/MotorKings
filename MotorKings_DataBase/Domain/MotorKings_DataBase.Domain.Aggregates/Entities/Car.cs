using MotorKings_DataBase.Domain.Aggregates.Entities.Base;

namespace MotorKings_DataBase.Domain.Aggregates.Entities;

public class Car : Entity<int>
{
    public string Brand { get; private set; } = string.Empty;
    public string Model { get; private set; } = string.Empty;
    public int Year { get; private set; }
    public string? Color { get; private set; }
    public int Mileage { get; private set; }
    public decimal? EngineVolume { get; private set; }
    public string? FuelType { get; private set; }
    public string? Transmission { get; private set; }
    public decimal Price { get; private set; }
    public string Status { get; private set; } = "available";
    public string? Description { get; private set; }
    public int BranchId { get; private set; }

    // Navigation properties
    public virtual Branch Branch { get; private set; } = null!;
    public virtual ICollection<Sale> Sales { get; private set; } = new List<Sale>();

    public Car() : base() { }

    public Car(string brand, string model, int year, decimal price, int branchId) : base()
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        BranchId = branchId;
    }

    public Car(int id, string brand, string model, int year, string? color, int mileage, decimal? engineVolume, string? fuelType, string? transmission, decimal price, string status, string? description, int branchId) : base(id)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        Mileage = mileage;
        EngineVolume = engineVolume;
        FuelType = fuelType;
        Transmission = transmission;
        Price = price;
        Status = status;
        Description = description;
        BranchId = branchId;
    }
}