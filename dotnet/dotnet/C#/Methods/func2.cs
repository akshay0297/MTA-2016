using System;
namespace ConsoleApplication1
{
    class Program
    {
        void disp(string s)
        {
            if (s == "Computer")
            {
                Console.WriteLine("I am going back");
				//returning the control
                return;
            }
            else
            {
                Console.WriteLine("Inside the called method, I got the value:" + s);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Inside the main method");
			//call the disp()
            p.disp("Computer");
            p.disp("Manipal");
            Console.WriteLine("Back in the main");


        }
    }
}
