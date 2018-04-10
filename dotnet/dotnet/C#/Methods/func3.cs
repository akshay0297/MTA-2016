using System;
namespace ConsoleApplication1
{
    class Program
    {
        string disp(string s1, string s2)
        {
            string fullname = string.Concat(s1, " ", s2);
            return fullname;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string m,n;
            Console.WriteLine("Inside the main method");
            Console.Write("Enter your first name please:");
            m = Console.ReadLine();
            Console.Write("Enter your last name please:");
            n = Console.ReadLine();
            string fname = p.disp(m, n);
            Console.WriteLine(fname);
            Console.WriteLine("Back in the main");


        }
    }
}
