// Declare loop control variable inside the for.
//Often the variable that controls a for loop is needed only for the purposes of the loop and
//is not used elsewhere. When this is the case, it is possible to declare the variable inside the
//initialization portion of the for.
//The scope of that variable ends when the for statement does.
using System;
class ForVar
{
    static void Main()
    {
        int sum = 0;
        int fact = 1;
        // Compute the factorial of the numbers 1 through 5.
        for (int i = 1; i <= 5; i++)
        {
            sum += i; // i is known throughout the loop.
            fact *= i;
        }
        // But, i is not known here.
        Console.WriteLine("Sum is " + sum);
        Console.WriteLine("Factorial is " + fact);
    }
}