using MotorKings_DataBase.Domain.Aggregates.Entities.Base;

namespace MotorKings_DataBase.Domain.Aggregates.Entities;

public class Sale : Entity<int>
{
    public int CarId { get; private set; }
    public int CustomerId { get; private set; }
    public int EmployeeId { get; private set; }
    public int BranchId { get; private set; }
    public DateTime SaleDate { get; private set; }
    public decimal SalePrice { get; private set; }
    public string? PaymentMethod { get; private set; }
    public string? ContractNumber { get; private set; }

    // Navigation properties
    public virtual Car Car { get; private set; } = null!;
    public virtual Customer Customer { get; private set; } = null!;
    public virtual Employee Employee { get; private set; } = null!;
    public virtual Branch Branch { get; private set; } = null!;

    public Sale() : base() { }

    public Sale(int carId, int customerId, int employeeId, int branchId, decimal salePrice) : base()
    {
        CarId = carId;
        CustomerId = customerId;
        EmployeeId = employeeId;
        BranchId = branchId;
        SalePrice = salePrice;
        SaleDate = DateTime.UtcNow;
    }

    public Sale(int id, int carId, int customerId, int employeeId, int branchId, DateTime saleDate, decimal salePrice, string? paymentMethod, string? contractNumber) : base(id)
    {
        CarId = carId;
        CustomerId = customerId;
        EmployeeId = employeeId;
        BranchId = branchId;
        SaleDate = saleDate;
        SalePrice = salePrice;
        PaymentMethod = paymentMethod;
        ContractNumber = contractNumber;
    }
}