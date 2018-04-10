using System;
namespace ConsoleApplication1
{
    class Console_I_O
    {
        static void Main(string[] args)
        {
            GetUserData();            
        }
        static void GetUserData()
        {
            // Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();
            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.",userName, userAge);
            // Restore previous color.
            Console.ForegroundColor = prevColor;
			/*
			when you are defining a string literal that
contains segments of data whose value is not known until runtime, you are able to specify a placeholder
within the literal using this curly-bracket syntax. At runtime, the value(s) passed into
Console.WriteLine() are substituted for each placeholder.
The first parameter to WriteLine() represents a string literal that contains optional placeholders
designated by {0}, {1}, {2}, and so forth. Be very aware that the first ordinal number of a curly-bracket
placeholder always begins with 0. The remaining parameters to WriteLine() are simply the values to be
inserted into the respective placeholders.
If you have more uniquely numbered curly-bracket placeholders than fill arguments, you will receive a
format exception at runtime. However, if you have more fill arguments than placeholders, the unused fill
arguments are ignored.
			*/
        }
    }
}
