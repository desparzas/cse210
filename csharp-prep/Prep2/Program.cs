using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());
        string letter;

        if (percentage >= 90)
            letter = "A";
        else if (percentage >= 80)
            letter = "B";
        else if (percentage >= 70)
            letter = "C";
        else if (percentage >= 60)
            letter = "D";
        else
            letter = "F";

        if (percentage >= 70)
            Console.WriteLine("Congratulations, you passed the course!");
        else
            Console.WriteLine("Keep trying! You'll get it next time.");

        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7 && percentage < 90)
            sign = "+";
        else if (lastDigit < 3 && percentage >= 60)
            sign = "-";

        if (letter == "A" && sign == "+")
            sign = "";
        if (letter == "F")
            sign = "";

        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}