
using System;
// Use commas in a for statement.
/*
 * The for loop allows you to use two or more variables to control the loop. When using
multiple loop control variables, the initialization and increments statements for each
variable are separated by commas.
 */
class Comma
{
    static void Main()
    {
        int i, j;
        for (i = 0, j = 10; i < j; i++, j--)
            Console.WriteLine("i and j: " + i + " " + j);
    }

}