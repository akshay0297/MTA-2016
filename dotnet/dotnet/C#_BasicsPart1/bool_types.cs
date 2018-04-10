using System;
class datatype_details
{
        
        static void Main(string[] args)
        {
         bool_types();              
        }
        static void bool_types()
        {
		/*
		Since the C# bool keyword is simply a shorthand notation for the System.Boolean structure, it is also
		possible to allocate any data type using its full name
		*/
		// Declare 3 bools on a single line.
		bool b1 = true, b2 = false, b3 = b1;
		// Use System.Boolean data type to declare a bool.
		System.Boolean b4=false;
		Console.WriteLine("Your data: {0}, {1}, {2}, {3}",b1, b2, b3, b4);
        }
		
		
		
		
		
		
		
		
		
}

