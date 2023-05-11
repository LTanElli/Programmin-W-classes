using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");
        //loop starts here?
        Console.WriteLine("Please select one of the folowwing choices. (type the number)");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        //if statements?
    }
}

public class PromptGenerator
{
    //attributes
    public List<string> promptList = new List<string>("What was the emotion that you felt the most today?", "What was the biggest thing that you accomplished?", "What is something that you wish you did today?", "How are you feeling right now?", "What was the best thing you ate/drank today?");

    public Random randPrompt = new Random();

    public PromptGenerator(List<string> pg, Random rp) {
        promptList = pg;
        randPrompt = rp;
    }

    public void randomPrompt() {
        int prompt = randPrompt.Next(promptList.Count);
        string currPrompt = promptList[prompt];
        Console.WriteLine($"{currPrompt}");
    }
}

public class Entry
{

    string userInput;
    

    public Entry(string ui) {
        userInput = ui;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    }

    public void UserChoice() {
        Console.WriteLine(">");
        userInput = Console.ReadLine();

    }

    //date method
    
}

public class Journal
{
    public List<Entry> entryList = new List<Entry>();
    public Journal(List<Entry> en) {
        entryList = en;
    }

    public void DisplayEntryList() {

    }
}

public class FileManager
{
    public Journal SaveJournal(Journal journal, string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (var entry in journal.entryList) {
                string data = $"{entry.date};{entry.prompt};{entry.text}";

                outputFile.WriteLine(data);
            }
        }

    }

    public Journal LoadJournal(string filename) {

        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal();

        foreach (string line in lines) {

            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry.date = date;
            entry.prompt = prompt;
            entry.text = text;

            journal.entryList.Add(entry);
        }
    }
}