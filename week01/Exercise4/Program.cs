using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>(); 
        int currentNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber == 0)
                break; 

            userNumbers.Add(currentNumber); 
        }

        int totalSum = 0;
        foreach (int num in userNumbers)
        {
            totalSum += num;
        }

        double average = totalSum / (double)userNumbers.Count;

        int maxNumber = userNumbers[0];
        foreach (int num in userNumbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}