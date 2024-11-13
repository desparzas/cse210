using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
        bool playAgain;
        do {
            int magicNumber = randomGenerator.Next(1, 101);
            playAgain = false;
            int guess;
            int attempts = 0;

            Console.WriteLine("I have picked a magic number between 1 and 100.");
                
            do {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber) {
                    Console.WriteLine("Higher");
                } else if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                }
                else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {attempts} attempts.");
                }
            } while (guess != magicNumber); 

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response == "yes") {
                playAgain = true;
            }
        } while (playAgain); 
        Console.WriteLine("Thanks for playing!");
    }
}