public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Menú principal del juego
        bool exit = false;
        while (!exit)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    RecordEvent();
                    break;
                case 4:
                    SaveGoals();
                    break;
                case 5:
                    LoadGoals();
                    break;
                case 6:
                    exit = true;
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("No goals available.");
            Console.WriteLine("");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        // Implementación para crear diferentes tipos de metas
        // Este método debería solicitar al usuario el tipo de meta y sus detalles
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the short name of the goal: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case 3:
                Console.Write("Enter the target amount for this goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        if (_goals.Count == 0)
        {
            return;
        }        
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[goalIndex].RecordEvent();
        _score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        DisplayPlayerInfo();
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";
        string[]lines = new string[_goals.Count];
        for (int i = 0; i < _goals.Count; i++)
        {
            lines[i] = _goals[i].ToSaveString();
        }

        File.WriteAllLines(fileName, lines);


        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        string fileName = "goals.txt";
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No goals to load.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        _goals = new List<Goal>();
        _score = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string type = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            Goal newGoal = null;

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    newGoal = new SimpleGoal(shortName, description, points);
                    ((SimpleGoal)newGoal).SetIsComplete(isComplete);
                    if (isComplete)
                    {
                        _score += points;
                    }
                    break;
                case "EternalGoal":
                    newGoal = new EternalGoal(shortName, description, points);
                    break;
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                    ((ChecklistGoal)newGoal).SetAmountCompleted(amountCompleted);
                    break;
            }

            _goals.Add(newGoal);
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}