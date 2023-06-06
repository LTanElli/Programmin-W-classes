using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        var actone = new Activity(1000);
        
        actone.ShowCountdown();

    }

    
}

public class Activity 
{
    protected string _startMessage;
    protected string _endMessage;
    protected string _name;
    protected int _duration;
    protected string _description;

    public Activity (int duration) {
        _duration = duration;
    }

    public void DisplayStart() {

    }

    public void DisplayEnd () {

    }

    public void ShowSpinner(int duration) {
        List<string> animations = new List<string> {
            "-",
            "\\",
            "|",
            "/",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;
        while(DateTime.Now < endTime) {
            string frame = animations[animationIndex];
            Console.Write(frame);

            Thread.Sleep(250);

            Console.Write("\b \b");

            animationIndex++;

            if (animationIndex >= animations.Count) {
                animationIndex = 0;
            }
        }
        Console.WriteLine("finished");
    }

    public void ShowCountdown() {
        List<string> animations = new List<string> {
            "5..",
            "4..",
            "3..",
            "2..",
            "1..",
            "Go!",
        };

        

        foreach (var a in animations) {
            
            Console.Write(a);

            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");    
        }
        Console.WriteLine("finished");
    }
}

public class ListeningActivity
{
    List<string> _questions = new List<string>();
    string _randomQuestion;
    int _duration;

    public ListeningActivity(int duration) {
        _duration = duration;
    }

    public void GetRandomQuestion() {

    }

    public void DisplayQuestion() {

    }
}

public class BreathingActivity
{
    int _duration;

    public BreathingActivity(int duration) {
        _duration = duration;
    }

    public void BreathCycle() {

    }
}

public class ReflectingActivity
{
    int _duration;
    List<string> _prompts = new List<string>();
    string _randomPrompt;

    public ReflectingActivity(int duration) {
        _duration = duration;
    }

    public void GetRandomPrompt() {

    }

    public void DisplayPrompt() {

    }
}