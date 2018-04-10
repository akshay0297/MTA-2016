using System;
namespace Console_Class
{
    class Console_Class
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            Console.Title = "My C# App";
            Console.Beep();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
		
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Welcome to My C# App *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;
           
			//restoring the forecolor back to white
			 Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            
        }
    }
}
