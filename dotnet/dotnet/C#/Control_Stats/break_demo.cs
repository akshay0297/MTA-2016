// Find the smallest factor of a value.
using System;
class FindSmallestFactor
{
    static void Main()
    {
        int factor = 1;
        Console.Write("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= num / i; i++)
        {
            if ((num % i) == 0)
            {
                factor = i;
                break; // stop loop when factor is found
            }
        }
        Console.WriteLine("Smallest factor is " + factor);
    }
}