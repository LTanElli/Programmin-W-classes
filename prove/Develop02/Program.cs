using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Please select one of the folowwing choices. (type the number)");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write(">>>");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "1") {

        }
        if (userInput == "2") {

        }
        if (userInput == "3") {

        }
        if (userInput == "4") {

        }
        if (userInput == "5") {

        }
    }
}

public class PromptGenerator
{
    //attributes
    List<string> promptList = new List<string>{"What was the emotion that you felt the most today?", "What was the biggest thing that you accomplished?", "What is something that you wish you did today?", "How are you feeling right now?", "What was the best thing you ate/drank today?"};

    Random randPrompt = new Random();

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
    }

    userInput = Console.ReadLine();

}

public class Journal
{

}