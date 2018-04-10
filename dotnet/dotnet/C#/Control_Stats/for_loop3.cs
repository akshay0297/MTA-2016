// Loop condition can be any bool expression.
//The conditional expression controlling a for loop can be any valid expression that produces
//a bool result.
using System;
class forDemo
{
    static void Main()
    {
        int i, j;
        bool done = false;
        for (i = 0, j = 100; !done; i++, j--)
        {
            if (i * i >= j) done = true;
            Console.WriteLine("i, j: " + i + " " + j);
        }
    }
}