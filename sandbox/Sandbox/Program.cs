using System;

class Program
{
    static void Main(string[] args)
    {
        //object or instance
        var layne = new Person("Layne", "Moseley");
        var dave = new Person("Dave", "Chappelle");

        layne.Breathe();
        layne.Talk();
        dave.Talk();
        dave.Walk();
    }
}

// classification
class Person 
{
    //attributes or properties
    string firstName;
    string lastName;


    //constructor, kinda like a function
    public Person(string fn, string ln) {
        firstName = fn;
        lastName = ln;
    }


    //behaviors or methods
    public void Breathe() {
        Console.WriteLine($"{firstName}: *Breathing*");
    }

    public void Walk() {
        Console.WriteLine($"{firstName}: *Walking*");
    }

    public void Talk() {
        Console.WriteLine($"Hi, My name is {FullName()}.");
    }
    public string FullName() {
        return firstName + " " + lastName;
        //string full = String.Concat(firstName, lastName);
        //return full;
        //return $"{firstName} {lastName}";
    }

}