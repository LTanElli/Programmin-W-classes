using System;
using System.IO;


abstract class Goal
{
    public string Name;
    public int Value;
    public bool IsComplete;

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsComplete = false;
    }

    public abstract void DisplayProgress();
    public abstract void Complete();
    public abstract void Reset();
    public abstract void Save(StreamWriter writer);
    public abstract void Load(string[] data);
}


class SimpleGoal:Goal
{
    public SimpleGoal(string name, int value):base(name, value)
    {

    }

    public override void DisplayProgress()
    {
        
    }

    public override void Complete()
    {
        IsComplete = true;
    }

    public override void Reset()
    {
        IsComplete = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Simple,{Name},{Value},{IsComplete}");
    }

    public override void Load(string[] data)
    {
        Name = data[1];
        Value = int.Parse(data[2]);
        IsComplete = bool.Parse(data[3]);
    }
}

class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {

    }

    public override void DisplayProgress()
    {

    }

    public override void Complete()
    {
        IsComplete = true;
    }

    public override void Reset()
    {
        IsComplete = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Eternal,{Name},{Value},{IsComplete}");
    }

    public override void Load(string[] data)
    {
        Name = data[1];
        Value = int.Parse(data[2]);
        IsComplete = bool.Parse(data[3]);
    }
}

class ChecklistGoal : Goal
{
    public int Progress;
    public int Target;
    public int BonusPoints;

    public ChecklistGoal(string name, int value, int target, int bonusPoints) : base(name, value)
    {
        Progress = 0;
        Target = target;
        BonusPoints = bonusPoints;
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Completed {Progress}/{Target} times");
    }

    public override void Complete()
    {
        Progress++;
        if (Progress >= Target)
        {
            IsComplete = true;
        }
    }

    public override void Reset()
    {
        IsComplete = false;
        Progress = 0;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Checklist,{Name},{Value},{IsComplete},{Progress},{Target},{BonusPoints}");
    }

    public override void Load(string[] data)
    {
        Name = data[1];
        Value = int.Parse(data[2]);
        IsComplete = bool.Parse(data[3]);
        Progress = int.Parse(data[4]);
        Target = int.Parse(data[5]);
        BonusPoints = int.Parse(data[6]);
    }
}

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
{
    LoadGoals();
    LoadScore();

    bool isRunning = true;
    while (isRunning)
    {
        Console.Clear();
        Console.WriteLine("========== Goal Tracker ==========");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Show Goals");
        Console.WriteLine("4. Show Score");
        Console.WriteLine("5. Save Goals and Score");
        Console.WriteLine("6. Exit");
        Console.Write("Select an option: ");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                CreateNewGoal();
                break;
            case "2":
                RecordEvent();
                break;
            case "3":
                ShowGoals();
                break;
            case "4":
                ShowScore();
                break;
            case "5":
                SaveGoals();
                SaveScore();
                Console.WriteLine("Goals and Score saved successfully.");
                break;
            case "6":
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}


    static void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("========== Create New Goal ==========");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the value of the goal: ");
        int value = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(name, value));
                Console.WriteLine("Simple goal created successfully.");
                break;
            case "2":
                goals.Add(new EternalGoal(name, value));
                Console.WriteLine("Eternal goal created successfully.");
                break;
            case "3":
                Console.Write("Enter the target number of completions for the checklist goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing all of the checklist goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, target, bonusPoints));
                Console.WriteLine("Checklist goal created successfully.");
                break;
            default:
                Console.WriteLine("Invalid goal type option.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("========== Record Event ==========");
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            Goal selectedGoal = goals[goalNumber];
            selectedGoal.Complete();
            score += selectedGoal.Value;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void ShowGoals()
    {
        Console.Clear();
        Console.WriteLine("========== Goals ==========");

        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.Write($"{i + 1}. {goal.Name}");

            if (goal.IsComplete)
            {
                Console.Write(" [X]");
            }
            else
            {
                Console.Write(" [ ]");
            }

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($" - ");
                checklistGoal.DisplayProgress();
            }

            Console.WriteLine();
        }
    }

    static void ShowScore()
    {
        Console.Clear();
        Console.WriteLine("========== Score ==========");
        Console.WriteLine($"Current Score: {score}");
    }

    static void LoadGoals()
    {
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string goalType = data[0];
                string name = data[1];
                int value = int.Parse(data[2]);

                switch (goalType)
                {
                    case "Simple":
                        goals.Add(new SimpleGoal(name, value));
                        break;
                    case "Eternal":
                        goals.Add(new EternalGoal(name, value));
                        break;
                    case "Checklist":
                        int progress = int.Parse(data[3]);
                        int target = int.Parse(data[4]);
                        int bonusPoints = int.Parse(data[5]);
                        goals.Add(new ChecklistGoal(name, value, target, bonusPoints));
                        break;
                }
            }
        }
    }

    static void LoadScore()
    {
        using (StreamReader reader = new StreamReader("score.txt"))
        {
            string line = reader.ReadLine();
            
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                goal.Save(writer);
            }
        }
    }

    static void SaveScore()
    {
        using (StreamWriter writer = new StreamWriter("score.txt"))
        {
            writer.WriteLine(score);
        }
    }
}
