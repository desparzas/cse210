public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        // Add more prompts...
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life.";
    }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Console.WriteLine("Start listing...");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}