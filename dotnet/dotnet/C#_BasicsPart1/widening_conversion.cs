 using System;
 class widening_conversion
    {
        static void Main(string[] args)
        {
			// Add two shorts and print the result.
			short numb1 = 9, numb2 = 10;
			Console.WriteLine("{0} + {1} = {2}",
			numb1, numb2, Add(numb1, numb2));
        }
		static int Add(int x, int y)
		{
			return x + y;
		}
    }
	/*
	Notice that the Add() method expects to be sent two int parameters. However, the Main() method
is, in fact, sending in two short variables. While this might seem like a complete and total mismatch of
data types, the program compiles and executes without error, returning the expected result of 19.
The reason the compiler treats this code as syntactically sound is due to the fact that there is no
possibility for loss of data. Given that the maximum value of a short (32,767) is well within the maximum
range of an int (2,147,483,647), the compiler implicitly widens each short to an int. Formally speaking,
widening is the term used to define an implicit upward cast that does not result in a loss of data.
	*/