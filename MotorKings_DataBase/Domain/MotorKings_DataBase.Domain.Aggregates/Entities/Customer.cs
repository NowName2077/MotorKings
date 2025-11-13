using MotorKings_DataBase.Domain.Aggregates.Entities.Base;

namespace MotorKings_DataBase.Domain.Aggregates.Entities;

public class Customer : Entity<int>
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string? Email { get; private set; }
    public string Phone { get; private set; } = string.Empty;
    public string? Address { get; private set; }

    // Navigation properties
    public virtual ICollection<Sale> Sales { get; private set; } = new List<Sale>();

    public Customer() : base() { }

    public Customer(string firstName, string lastName, string phone) : base()
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }

    public Customer(int id, string firstName, string lastName, string? email, string phone, string? address) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Address = address;
    }
}