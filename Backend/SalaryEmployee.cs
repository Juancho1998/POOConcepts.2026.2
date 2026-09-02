namespace Backend;

public class SalaryEmployee : Employee //Esto sirve para heredar de otra clase o interfaz
{
    //Fields
    private decimal _salary;

    //Constructors
    public SalaryEmployee(int id, Date bornDate, Date hireDate, string firstName, string lastName, bool isActive, decimal salary)
    : base(id, bornDate, hireDate, firstName, lastName, isActive)
    {
        Salary = salary;
    }

    //Propierties
    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    //Public Methods
    public override decimal GetValueToPay() => _salary;
    public override string ToString() => $"{base.ToString()}\n\t" +
               $"Salary..............: {GetValueToPay(),20:C2}";

    //Private Methods

    private decimal ValidateSalary(decimal salary)
    {
        if(salary < 2000000)
        {
            throw new Exception($"The salary: {salary:C2}, is less than the minimum");
        }  
        return salary;
    }

}
