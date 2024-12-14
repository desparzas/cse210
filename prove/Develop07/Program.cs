using System;

class Program
{    
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3.0),
            new Swimming(DateTime.Now, 45, 70),
            new Cycling(DateTime.Now, 30, 10)
        };
        Console.WriteLine("Activities:");
        foreach (Activity activity in activities)
        {
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("__________________________________________________________________________________________________");
        }
    }
}
