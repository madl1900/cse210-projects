using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;

        while (userNum != 0)
        {
            Console.Write("What number would you like to add to the list? ");
            string userNumStr = Console.ReadLine();
            userNum = int.Parse(userNumStr);

            if (userNum != 0)
            { 
                numbers.Add(userNum);
            }
        }
        int sum = 0;
        int max = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
            if (num > max)
            {
                max = num;
            }
        }
        int average = sum/numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}