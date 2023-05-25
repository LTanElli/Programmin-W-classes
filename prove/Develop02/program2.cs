using System;

public class Program
{
    static void Main(string[] args)
    {
        int userOption = 0;
        
        while (userOption != 4 && userOption != 5)
        {
            Journal journal = new Journal();
            userOption = 0;
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("Please choose one of the following options. (Enter the number.)");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            Console.WriteLine("");
            userOption = int.Parse(Console.ReadLine());

            if (userOption == 1)
            {
                //display prompt here
                Console.Write("Your Response: ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry());
            }
            else if (userOption == 2)
            {
                journal.DisplayEntries();
            }
            else if (userOption == 3)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            else if (userOption == 4)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.Load(filename);
            }
            else if (userOption == 5)
            {
                Console.WriteLine("Have a nice rest of your day!");
                break;
            }
            else
            {
                Console.WriteLine("Input is invalid. Please insert a number 1 through 5 according to the options in the menu.");
            }
        }
    }
}

public class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "What was the emotion that you felt the most today?",
        "What was the biggest thing that you accomplished?",
        "What is something that you wish you did today?",
        "How are you feeling right now?",
        "What was the best thing you ate/drank today?",
        "What is your goal for tomorrow?",
        "What is your favorite color?",
        "What is your quest?",
        "What is the capital of Assyria?"
    };

    public Random random = new Random();

    public string _randomPrompt;

    public string DisplayPrompt()
    {
        _randomPrompt = prompts[random.Next(0, prompts.Count)];
        Console.WriteLine($"{_randomPrompt}");
        return _randomPrompt;
    }

    //int index = random.Next(prompts.Count);
    //Console.WriteLine(prompts[index]);
}

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(new Entry());
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }

        
    }

    public void Load(string filename)
    {
        string line = "";
        using (StreamReader sr = new StreamReader("journal.txt"))
        {
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // string[] lines = System.IO.File.ReadAllLines(filename);
        // Journal journal = new Journal();

        // foreach (string line in lines) {

        //     string[] parts = line.Split(";");

        //     public string _date = parts[0];
        //     public string _prompt = parts[1];
        //     public string _text = parts[2];

        //     Entry entry = new Entry();
        //     entry._date = _date;
        //     entry._prompt = _prompt;
        //     entry._response = _response;

        //     journal._entries.Add(entry);
        // }
    }
}

public class Entry
{
    public string _randomPrompt;

    public string _response;

    public string _date = DateTime.Now.ToString("mm/dd/yyyy");

    //public string _keptEntry;

    public override string ToString()
    {
        return ($"Date: {_date} : Prompt: {_randomPrompt} : Response: {_response}");
    }
}