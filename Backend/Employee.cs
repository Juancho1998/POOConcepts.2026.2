namespace Backend;

public abstract class Employee
{

    //Constructors
    protected Employee(int id, Date bornDate, Date hireDate, string firstName, string lastName, bool isActive)
    {
        Id = id;
        BornDate = bornDate;
        HireDate = hireDate;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
    }
    //Properties
    public int Id { get; set; }

    public Date BornDate { get; set; } = null!;

    public Date HireDate { get; set;} = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsActive { get; set; }

    //Public Methods

    public abstract decimal GetValueToPay();

    public override string ToString() => $"{Id}\t{FirstName} {LastName}\n\t" +
               $"Born date...........: {BornDate,20}\n\t" +
               $"Hire date...........: {HireDate,20}";
               

}
