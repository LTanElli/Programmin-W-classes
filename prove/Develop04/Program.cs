using System;
using System.Threading;

abstract class Activity
{
    protected string Name { get; }
    protected string Description { get; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"=== {Name} ===");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);  // Pause for 2 seconds before starting
        PerformActivity(duration);
    }

    protected virtual void PerformActivity(int duration)
    {
        Console.WriteLine("Activity not implemented.");
    }

    protected void End(int duration)
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity.");
        Console.WriteLine($"Total duration: {duration} seconds");
        Thread.Sleep(2000);  // Pause for 2 seconds before finishing
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"Countdown: {i} seconds\r");
            Thread.Sleep(1000);
        }
    }
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity(int duration)
    {
        ShowStartMessage();

        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            duration -= 3;
            if (duration <= 0)
                break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            duration -= 3;
        }

        ShowEndMessage(duration);
    }

    private void ShowStartMessage()
    {
        Console.WriteLine("=== Starting the Breathing Activity ===");
        Console.WriteLine("Get ready to relax and focus on your breathing.");
        Thread.Sleep(2000);  // Pause for 2 seconds before starting
    }

    private void ShowEndMessage(int duration)
    {
        Console.WriteLine("=== Ending the Breathing Activity ===");
        End(duration);
    }
}

class ReflectionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    protected override void PerformActivity(int duration)
    {
        ShowStartMessage();

        Random random = new Random();

        while (duration > 0)
        {
            Console.WriteLine(prompts[random.Next(prompts.Length)]);

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                ShowSpinner();
                Thread.Sleep(2000);  // Pause for 2 seconds before showing the next question
            }

            duration -= questions.Length;
        }

        ShowEndMessage(duration);
    }

    private void ShowStartMessage()
    {
        Console.WriteLine("=== Starting the Reflection Activity ===");
        Console.WriteLine("Get ready to reflect on your past experiences.");
        Thread.Sleep(2000);  // Pause for 2 seconds before starting
    }

    private void ShowEndMessage(int duration)
    {
        Console.WriteLine("=== Ending the Reflection Activity ===");
        End(duration);
    }

    private void ShowSpinner()
    {
        string[] spinChars = new string[] { "-", "\\", "|", "/" };

        for (int i = 0; i < 4; i++)
        {
            foreach (string spinChar in spinChars)
            {
                Console.Write(spinChar + "\r");
                Thread.Sleep(100);
            }
        }
    }
}

class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity(int duration)
    {
        ShowStartMessage();

        Random random = new Random();
        int totalItems = 0;

        while (duration > 0)
        {
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            Console.WriteLine("You have a few seconds to think...");

            ShowCountdown(5);

            Console.WriteLine("Enter your list items (press Enter after each item, leave blank to finish):");

            string item = Console.ReadLine();
            int itemCount = 0;

            while (!string.IsNullOrEmpty(item))
            {
                itemCount++;
                item = Console.ReadLine();
            }

            totalItems += itemCount;
            duration -= 5;
        }

        Console.WriteLine($"Total items listed: {totalItems}");

        ShowEndMessage(duration);
    }

    private void ShowStartMessage()
    {
        Console.WriteLine("=== Starting the Listing Activity ===");
        Console.WriteLine("Get ready to list!");
        Thread.Sleep(2000);  // Pause for 2 seconds before starting
    }

    private void ShowEndMessage(int duration)
    {
        Console.WriteLine("=== Ending the Listing Activity ===");
        End(duration);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Activity Menu ===");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter your choice (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        Activity activity;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectionActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        activity.Start();
    }
}
