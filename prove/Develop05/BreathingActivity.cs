public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by guiding you through slow, deep breathing.";
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);  // Muestra el número actual.
            Thread.Sleep(1000);  // Pausa por 1 segundo.
            Console.Write("\b \b");  // Borra el número actual para reemplazarlo.
        }
    }

    public override void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(6);
        }
        EndActivity();
    }
}