using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Display welcome message
        DisplayWelcomeMessage();
    
        // Step 2: Prompt for and store the user's name
        string userName = PromptUserName();
    
        // Step 3: Prompt for and store the user's favorite number
        int favoriteNumber = PromptUserNumber();
    
        // Step 4: Calculate the square of the number
        int squaredNumber = SquareNumber(favoriteNumber);
    
        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number) {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}