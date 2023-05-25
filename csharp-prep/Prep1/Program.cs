using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
// class Name
// {
//     static void Second(string[] args)
//     {
//         Console.Write("What is your first name? ");
//         string firstName = Console.ReadLine();

//         Console.Write("What is your last name? ");
//         string lastName = Console.ReadLine();

//         Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
//     }
// }


// foreach (Word word in _words)
//         {
//             if (word.GetHidden())
//             {
//                 Console.Write(new string('_', word.GetText().Length) + " ");
//             }
//             else
//             {
//                 Console.Write(word.GetText() + " ");
//             }
//         }

//         Console.WriteLine();