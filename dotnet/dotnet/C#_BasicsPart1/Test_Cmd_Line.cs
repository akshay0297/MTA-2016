using System;
namespace ConsoleApplication1
{
    class Test_Command_Line_Args
    {
        static void Main(string[] args)
        {
            Console.WriteLine("total members in the list:"+args.Length);
			Console.WriteLine(args[0]);
		}
	}
}