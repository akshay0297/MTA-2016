using System;


class VarInitDemo
{
    /*
	
     * If a variable declaration includes an initializer, then that variable will be reinitialized
each time the block in which it is declared is entered.
This indirectly demonstrates the lifetime of the variable.
     */
    static void Main()
    {
        int x;
        for (x = 0; x < 3; x++)
        {
            int y = -1; // y is initialized each time block is entered
            Console.WriteLine("y is: " + y); // this always prints -1
            y = 100;
            Console.WriteLine("y is now: " + y);
        }
    }
}

