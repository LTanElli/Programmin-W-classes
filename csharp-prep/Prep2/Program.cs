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
                Console.WriteLine("You have an A+ in your class. Good for you.");
            }
            else if (gradeNumber >= 93)
            {
                Console.WriteLine("You have an A in your class. Very nice.");
            }
            else if (gradeNumber >= 90 && gradeNumber < 93)
            {
                Console.WriteLine("You have an A- in your class. Nice.");
            }
            else if (gradeNumber >= 87)
            {
                Console.WriteLine("You have an B+ in your class. Almost an A.");
            }
            else if (gradeNumber >= 83)
            {
                Console.WriteLine("You have a B in your class. Pretty good.");
            }
            else if (gradeNumber >= 80 && gradeNumber < 83)
            {
                Console.WriteLine("You have an B- in your class. Kinda good.");
            }
            else if (gradeNumber >= 77)
            {
                Console.WriteLine("You have an C+ in your class. Good I guess.");
            }
            else if (gradeNumber >= 73)
            {
                Console.WriteLine("You have a C in your class. Pretty okay if you ask me.");
            }
            else if (gradeNumber >= 70 && gradeNumber < 73)
            {
                Console.WriteLine("You have an C- in your class. Somewhat okay.");
            }
            else if (gradeNumber >= 67)
            {
                Console.WriteLine("You have an D+ in your class. You can do better.");
            }
            else if (gradeNumber >= 63)
            {
                Console.WriteLine("You have a D in your class. You can do much better.");
            }
            else if (gradeNumber >= 60 && gradeNumber < 63)
            {
                Console.WriteLine("You have an D- in your class. Almost failing, step it up.");
            }
            else if (gradeNumber < 60)
            {
                Console.WriteLine("You have an F in your class. You failure. Quit school.");
            }
            else
            {
                Console.WriteLine("You may have not entered in a number, try again?");
            }

            Console.Write("Would you like to enter another grade percentage? ");
            string another = Console.ReadLine().ToLower();
            if (another == "yes")
            {
                anotherGrade = true;
            }
            else if (another == "no")
            {
                anotherGrade = false;
            }
        }
    }
}