using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Math Assignment Details:");

        // var newAssignment = new Assignment("", "", "");
    }
}

class Person {
    protected string _name;

    public Person (string name) {
        _name = name;
    }
}

class Assignment: Person {
    protected string _topic;

    public Assignment(string name, string topic): base(name) {
        _topic = topic;
    }
}

class MathAssignment: Assignment {
    private string _section;
    private string _problems;

    public MathAssignment (string name, string topic, string section, string problems): base(name, topic) {
        _section = section;
    }

    public void GetMathHomework() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Topic: {_topic}");

        Console.WriteLine($"Section {_section} - Problem(s) {_problems}");
    }
}


