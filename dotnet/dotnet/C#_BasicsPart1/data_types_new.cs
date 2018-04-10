using System;
class data_types_with_new
{
        
        static void Main(string[] args)
        {
         data_types();              
        }
        static void data_types()
        {
		bool b = new bool(); // Set to false.
		int i = new int(); // Set to 0.
		double d = new double(); // Set to 0.
		DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
		Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
		
		/* error
		bool b1;
		Console.WriteLine(b1);
		*/
        }
}

