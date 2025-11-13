using MotorKings_DataBase.Domain.Aggregates.Entities.Base;

namespace MotorKings_DataBase.Domain.Aggregates.Entities;

public class Employee : Entity<int>
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Position { get; private set; } = string.Empty;
    public string? Email { get; private set; }
    public string Phone { get; private set; } = string.Empty;
    public decimal Salary { get; private set; }
    public DateTime HireDate { get; private set; }
    public bool IsActive { get; private set; } = true;
    public int BranchId { get; private set; }

    // Navigation properties
    public virtual Branch Branch { get; private set; } = null!;
    public virtual ICollection<Sale> Sales { get; private set; } = new List<Sale>();

    public Employee() : base() { }

    public Employee(string firstName, string lastName, string position, string phone, decimal salary, int branchId) : base()
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Phone = phone;
        Salary = salary;
        BranchId = branchId;
        HireDate = DateTime.UtcNow;
    }

    public Employee(int id, string firstName, string lastName, string position, string phone, decimal salary, int branchId, DateTime hireDate, bool isActive) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Phone = phone;
        Salary = salary;
        BranchId = branchId;
        HireDate = hireDate;
        IsActive = isActive;
    }
}