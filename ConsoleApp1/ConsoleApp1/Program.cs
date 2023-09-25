using ConsoleApp1;

Employee employee1 = new Employee ("Adam", "Sowa", 34);
Employee employee2 = new Employee ("Eva", "Kowalska", 54);
Employee employee3 = new Employee ("Jeży", "Gapa", 37);

employee1.AddScore(6);
employee1.AddScore(10);
employee1.AddScore(10);
employee1.AddScore(3);
employee1.AddScore(7);

employee2.AddScore(1);
employee2.AddScore(10);
employee2.AddScore(2);
employee2.AddScore(8);
employee2.AddScore(4);

employee3.AddScore(6);
employee3.AddScore(10);
employee3.AddScore(1);
employee3.AddScore(7);
employee3.AddScore(2);

Console.WriteLine(employee1 Name + " " + employee1 SurName + " " + employee1 Age + " " + employee1 Result + " ")
Console.WriteLine(employee2 Name + " " + employee2 SurName + " " + employee2 Age + " " + employee2 Result + " ")
Console.WriteLine(employee3 Name + " " + employee3 SurName + " " + employee3 Age + " " + employee4 Result + " ")

    List<Employee> employees = new List<Employee>()
    {
        employee1, employee2, employee3
    };
int BestResult = -1;
Employee? BestResultEmployee = null;


foreach (Employee employee in employees)
{
    if( employee Result > BestResult)
            {
        BestResult = employee.Result;
        BestResultEmployee = employee;
    }
}
Console.WriteLine("Najlepszy wynik ma :" + BestResultEmployee?.Name + " " + BestResultEmployee?.SurName + " " + BestResultEmployee?.Age + " " + Console.WriteLine(employee1 Name + " " + employee1 SurName + " " + employee1 Age + " " + employee1 Result + " " + BestResultEmployee?.Result + " ");