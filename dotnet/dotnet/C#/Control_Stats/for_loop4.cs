//In C#, it is possible for any or all of the initialization, condition, or iteration portions
//of the for loop to be empty.

using System;
class Empty
{
    static void Main()
    {
        int i=0;
        for (; i < 10; )
        {
            Console.WriteLine("Pass #" + i);
            i++; // increment loop control var
        }
    }
}