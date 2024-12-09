public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        // Add more prompts...
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        // Add more questions...
    };

    public ReflectionActivity()
    {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength.";
    }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            ShowSpinner(5);
        }
        EndActivity();
    }
}