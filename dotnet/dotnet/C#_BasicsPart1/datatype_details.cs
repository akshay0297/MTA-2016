using System;
namespace ConsoleApplication1
{
    class datatype_details
    {
        
        static void Main(string[] args)
        {
            GetTypeDetails();            
        }
        static void GetTypeDetails()
        {
			//MaxValue and MinValue properties that provide information regarding the range a given type can store.
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
		//TrueString/FalseString properties of bool(which yields the string "True" or "False", respectively)
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

            /*
             * C# textual data is represented by the string and char keywords
             * A string represents a contiguous set of characters (e.g., "Hello"), while the char can represent a
single slot in a string (e.g., 'H').
             * 
             */
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
            char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",
            char.IsPunctuation('?'));
           
            
            //parsing
			/*
			The .NET data types provide the ability to generate a variable of their underlying type given a textual
equivalent (e.g., parsing).
*/

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
        }
    }
}
