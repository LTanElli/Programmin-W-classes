using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while (true){

            Console.Write("Please enter a number (enter 0 to stop): ");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);

            if (number == 0) {
                break;
            }

            numbers.Add(number);
        }
        int sum = 0;
        int count = 0;
        foreach (var num in numbers) {
            sum = sum + num;
            count = count + 1;
        }

        Console.WriteLine($"The sum of the numbers in the list is {sum}");

        int average = sum / count;

        Console.WriteLine($"The average of the list is {average}");

        // float average = (float)sum / (float)numbers.Count; better way to do it.
    }
}