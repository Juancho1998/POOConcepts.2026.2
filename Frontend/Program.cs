using Backend;

try
{
    //var date1 = new Date(2027, 2,29);
    //var date2 = new Date(1994, 9, 23);
    //Console.WriteLine(date1);
    //Console.WriteLine(date2);

    var employee1 = new SalaryEmployee(1010, new Date(1976, 1, 13), new Date(2020, 11, 12), "Marta", "Lopez", true, 2100000);
    var employee2 = new CommissionEmployee(2020, new Date(2000, 7, 12), new Date(2020, 12, 3), "Sandra", "Cardona", true, 0.03f, 800000000);
    var employee3 = new CommissionEmployee(3030, new Date(1990, 4, 23), new Date(2010, 10, 10), "Hector", "Pulido", true, 0.03f, 26000000);
    var employee4 = new HourlyEmployee(4040, new Date(2020, 10, 04), new Date(2020, 10, 04), "Victor", "Maldonado", true, 25000, 113.5f);
    var employee5 = new HourlyEmployee(5050, new Date(2020, 10, 04), new Date(2020, 10, 04), "Dora", "Ruiz", true, 67000, 81f);
    var employee6 = new BaseCommissionEmployee(6060, new Date(2020, 10, 04), new Date(2020, 10, 04), "Lucia", "Hernandez", true, 0.0125f, 80000000, 600000);

    var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
    decimal total = 0;


    foreach (var employee in employees)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(employee);
        total += employee.GetValueToPay();
     
    }
    Console.WriteLine("==================================================");
    Console.WriteLine($"TOTAL.......................: {total,20:C2}");
    Console.WriteLine("==================================================");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


