// the parent class showing the "virtual" keyword included
public class Employee
{
    private float salary = 100f;

    public virtual float CalculatePay()
    {
        return salary;
    }
}

// a child class
public class HourlyEmployee : Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours; // pay is calculated differently
    }
}