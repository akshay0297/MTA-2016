// The body of a loop can be empty.
//In C#, the body associated with a for loop (or any other loop) can be empty. This is because
//a empty statement is syntactically valid
//the following program uses a bodyless loop to sum the numbers 1 through 5
using System;
class Empty3
{
    static void Main()
    {
        int i;
        int sum = 0;
        // Sum the numbers through 5.
        for (i = 1; i <= 5; sum += i++) ;
        Console.WriteLine("Sum is " + sum);
    }
}