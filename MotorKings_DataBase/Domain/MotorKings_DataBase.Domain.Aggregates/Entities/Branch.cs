using MotorKings_DataBase.Domain.Aggregates.Entities.Base;

namespace MotorKings_DataBase.Domain.Aggregates.Entities;

public class Branch : Entity<int>
{
    public string Name { get; private set; } = String.Empty;
    public string Address { get; private set; } = String.Empty;
    public string Phone { get; private set; } = String.Empty;
    public string? Email { get; private set; }
    public string Manager { get; private set; } = string.Empty;
    public DateTime OpeningDate { get; private set; }
    public bool IsActive { get; private set; } = true;
    
    public virtual ICollection<Car> Cars { get; private set; } = new List<Car>();
    public virtual ICollection<Employee> Employees { get; private set; } = new List<Employee>();
    public virtual ICollection<Sale> Sales { get; private set; } = new List<Sale>();

    public Branch() : base() { }

    public Branch(string name, string address, string phone, string manager) : base()
    {
        Name = name;
        Address = address;
        Phone = phone;
        Manager = manager;
        OpeningDate = DateTime.UtcNow;
    }

    public Branch(int id, string name, string address, string phone, string manager, DateTime openingDate, bool isActive) : base(id)
    {
        Name = name;
        Address = address;
        Phone = phone;
        Manager = manager;
        OpeningDate = openingDate;
        IsActive = isActive;
    }
}