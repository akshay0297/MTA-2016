// Accept a number if it is between 20 and 50, 
//should ask for input again if number is <=20 or >=50
using System;
class DoWhileDemo
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        while ((n < 20 || n == 20) || (n > 50 || n == 50));
    }
}