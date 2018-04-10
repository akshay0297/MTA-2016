// Accept a number if it is between 10 and 50
using System;
class DoWhileDemo
{
    static void Main()
    {
        int num;
        
        do
        {
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
        } 
        while (num < 10 || num>50);
        Console.WriteLine("Num="+num);
    }
}