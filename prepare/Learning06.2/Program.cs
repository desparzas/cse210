using System;

class Program
{
    static void DisplayPayCheck(Employee e)
    {
        float pay = e.CalculatePay();
        Console.WriteLine($"Paycheck: {pay}");
    }

    static void Main(string[] args)
    {
        // Create a list of Employees
        List<Employee> employees = [];
        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());

        // Get a custom calculation for each one
        foreach(Employee employee in employees)
        {
            DisplayPayCheck(employee);
        }
    }
}