using System;

class NestVar
{
/*
Although blocks can be
nested, no variable declared within an inner scope can have the same name as a variable
declared by an enclosing scope.
such a declaration hides the outer variable and the designers of C# felt that this type of name hiding
could easily lead to programming errors and disallowed it.
*/
    static void Main()
    {
        int count;
        for (count = 0; count < 10; count = count + 1)
        {
            Console.WriteLine("This is count: " + count);
            int count; // illegal!!!
            for (count = 0; count < 2; count++)
                Console.WriteLine("This program is in error!");
        }
    }
}
