using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1, 101);

        int count = 0;
        bool again = true;
        bool incorrect = true;

        while (again == true)
        {
            while (incorrect == true)
            {
                Console.WriteLine("This is a number guessing game.");
                Console.Write("Guess a number between 1 and 100: ");
                string userGuess = Console.ReadLine();

                int userNumber = int.Parse(userGuess);
                count = count + 1;

                if (userNumber > magicNumber){
                    Console.WriteLine("Too High");
                }   
                else if (userNumber < magicNumber){
                    Console.WriteLine("Too Low");
                }
                else if (userNumber == magicNumber){
                    Console.WriteLine("That is correct");
                    Console.WriteLine($"It took you {count} guesses.");
                    incorrect = false;
                }
                else{
                    Console.WriteLine("Is that a number?");
                }
            }
            Console.WriteLine("Do you wish to play again?");
            string shouldContinue = Console.ReadLine().ToLower();

            if (shouldContinue == "yes"){
                count = 0;
            }
            else if (shouldContinue == "no"){
                again = false;
            }
        }

    }
}