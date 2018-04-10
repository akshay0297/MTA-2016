using System;
namespace ConsoleApplication1
{
    class Program
    {
        void disp()
        {
            Console.WriteLine("Inside the called method");
        }

        static void Main(string[] args)
        {
			//creating an object of the class
            Program p = new Program();
			
            Console.WriteLine("Inside the main method");
			//call to the disp()
            p.disp();
            Console.WriteLine("Back in the main");

        }
    }
}
