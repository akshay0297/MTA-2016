using System;
namespace ConsoleApplication1
{
    class Test_Command_Line_Args
    {
        static void Main(string[] args)
        {
            Console.WriteLine("total members in the list:"+args.length);
			Console.WriteLine(args[0]);
		}
}
}
			
			
/*			
			
			
			foreach (var x in args)
            {
                Console.WriteLine(x);
            }
         
			for(int i = 0; i < args.Length; i++)
			Console.WriteLine("Arg: {0}", args[i]);
		
			/*
			Finally, you are also able to access command-line arguments using the static GetCommandLineArgs()
method of the System.Environment type. The return value of this method is an array of strings. The first
index identifies the name of the application itself, while the remaining elements in the array contain the
individual command-line arguments.
			*/
			/*
			string[] theArgs = Environment.GetCommandLineArgs();
			foreach(string arg in theArgs)
			Console.WriteLine("Arg: {0}", arg);
			*/
			/*
			on the developer prompt, compile the application as usual as, csc Test_Command_Line_Args.csc
			Provide the args at the time of execution as :
			Test_Command_Line_Args C# Java VB
			
			*/
        }
    }
}
