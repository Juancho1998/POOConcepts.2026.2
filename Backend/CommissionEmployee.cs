namespace Backend;

public class CommissionEmployee : Employee
{
    //Fields
    private float _commissionPercentage;
    private decimal _sales;


    //Constructors
    public CommissionEmployee(int id, Date bornDate, Date hireDate, string firstName, string lastName, bool isActive, float commissionPercentage, decimal sales)
        : base(id, bornDate, hireDate, firstName, lastName, isActive)
    {
        CommissionPercentage = commissionPercentage;
        Sales = sales;
    }

    //Propierties
    public float CommissionPercentage 
    { 
        get => _commissionPercentage; 
        set => _commissionPercentage = ValidateCommissionPercentage(value); 
    }
    public decimal Sales 
    { 
        get => _sales; 
        set => _sales = ValidateSales(value); 
    }

    //Public Methods
    public override decimal GetValueToPay() => _sales * (decimal)_commissionPercentage;
   
    //Private Methods
    private float ValidateCommissionPercentage(float commissionPercentage)
    {
        if (commissionPercentage < 0 || commissionPercentage > 0.3)
        {
            throw new Exception($"The commission percentaje: {commissionPercentage:P2}, is not valid.");
        }
        return commissionPercentage;
    }
    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new Exception($"The sales: {sales:C2}, is not valid.");
        }
        return sales;
    }



}
