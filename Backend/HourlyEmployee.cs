namespace Backend;

public class HourlyEmployee : Employee
{

    //Fields

    private decimal _hourValue;
    private float _workingHours;

    //Construnctors
    public HourlyEmployee(int id, Date bornDate, Date hireDate, string firstName, string lastName, bool isActive, decimal hourValue, float workingHours)
        : base(id, bornDate, hireDate, firstName, lastName, isActive)
    {
        HourValue = hourValue;
        WorkingHours = workingHours;
    }

    //Propierties
    public decimal HourValue
    {
        get => _hourValue;
        set => _hourValue = ValidateHourValue(value);
    }
    public float WorkingHours
    {
        get => _workingHours;
        set => _workingHours = ValidateWorkingHours(value);
    }



    //Public Methods
    public override decimal GetValueToPay() => HourValue * (decimal)WorkingHours;

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
               $"Working hours.......: {WorkingHours,20:N2}\n\t" +
               $"Hour value..........: {HourValue,20:C2}\n\t" +
               $"Salary..............: {GetValueToPay(),20:C2}";
    }

    //Private Methods
    private decimal ValidateHourValue(decimal HourValue)
    {
        if (HourValue < 10000)
        {
            throw new Exception($"The hour value: {HourValue:C2}, is less than the $10.000.00.");
        }
        return HourValue;
    }
    private float ValidateWorkingHours(float WorkingHours)
    {
        if (WorkingHours < 0)
        {
            throw new Exception($"The working hours: {WorkingHours:N2}, is less than the zero.");
        }
        return WorkingHours;
    }

}
