using System;

class Program
{
    static void Main(string[] args)
    {
        bool anotherGrade = true;

        while (anotherGrade == true)
        {
            Console.Write("What is your grade percentage? ");
            string grade = Console.ReadLine();
            int gradeNumber = int.Parse(grade);

            if (gradeNumber >= 97)
            {
                Console.WriteLine("You have an A+ in your class");
            }
            else if (gradeNumber >= 93)
            {
                Console.WriteLine("You have an A in your class.");
            }
            else if (gradeNumber >= 90 && gradeNumber < 93)
            {
                Console.WriteLine("You have an A- in your class.");
            }
            else if (gradeNumber >= 87)
            {
                Console.WriteLine("You have an B+ in your class");
            }
            else if (gradeNumber >= 83)
            {
                Console.WriteLine("You have a B in your class.");
            }
            else if (gradeNumber >= 80 && gradeNumber < 83)
            {
                Console.WriteLine("You have an B- in your class.");
            }
            else if (gradeNumber >= 77)
            {
                Console.WriteLine("You have an C+ in your class");
            }
            else if (gradeNumber >= 73)
            {
                Console.WriteLine("You have a C in your class.");
            }
            else if (gradeNumber >= 70 && gradeNumber < 73)
            {
                Console.WriteLine("You have an C- in your class.");
            }
            else if (gradeNumber >= 67)
            {
                Console.WriteLine("You have an D+ in your class");
            }
            else if (gradeNumber >= 63)
            {
                Console.WriteLine("You have a D in your class.");
            }
            else if (gradeNumber >= 60 && gradeNumber < 63)
            {
                Console.WriteLine("You have an D- in your class.");
            }
            else if (gradeNumber < 60)
            {
                Console.WriteLine("You have an F in your class. You failure.");
            }
            else
            {
                Console.WriteLine("You may have not entered in a number, try again?");
            }

            Console.Write("Would you like to enter another grade percentage? ");
            string another = Console.ReadLine();
            if (another == "yes")
            {
                anotherGrade = true;
            }
            else if (another == "no")
            {
                anotherGrade = false;
            }
        }

        // Console.Write("What is your grade percentage? ");
        // string grade = Console.ReadLine();
        // int gradeNumber = int.Parse(grade);

        // if (gradeNumber >= 97)
        // {
        //     Console.WriteLine("You have an A+ in your class");
        // }
        // else if (gradeNumber >= 93)
        // {
        //     Console.WriteLine("You have an A in your class.");
        // }
        // else if (gradeNumber >= 90 && gradeNumber < 93)
        // {
        //     Console.WriteLine("You have an A- in your class.");
        // }
        // else if (gradeNumber >= 87)
        // {
        //     Console.WriteLine("You have an B+ in your class");
        // }
        // else if (gradeNumber >= 83)
        // {
        //     Console.WriteLine("You have a B in your class.");
        // }
        // else if (gradeNumber >= 80 && gradeNumber < 83)
        // {
        //     Console.WriteLine("You have an B- in your class.");
        // }
        // else if (gradeNumber >= 77)
        // {
        //     Console.WriteLine("You have an C+ in your class");
        // }
        // else if (gradeNumber >= 73)
        // {
        //     Console.WriteLine("You have a C in your class.");
        // }
        // else if (gradeNumber >= 70 && gradeNumber < 73)
        // {
        //     Console.WriteLine("You have an C- in your class.");
        // }
        // else if (gradeNumber >= 67)
        // {
        //     Console.WriteLine("You have an D+ in your class");
        // }
        // else if (gradeNumber >= 63)
        // {
        //     Console.WriteLine("You have a D in your class.");
        // }
        // else if (gradeNumber >= 60 && gradeNumber < 63)
        // {
        //     Console.WriteLine("You have an D- in your class.");
        // }
        // else if (gradeNumber < 60)
        // {
        //     Console.WriteLine("You have an F in your class. You failure.");
        // }
        // else
        // {
        //     Console.WriteLine("You may have not entered in a number, try again?");
        // }
    }
}