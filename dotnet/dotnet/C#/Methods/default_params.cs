using System;
class default_params
{
	static void Main()
	{
		EnterLogData("Oh no! Grid can't find data");
		EnterLogData("Oh no! I can't find the payroll data", "CFO");
	
	}
	static void EnterLogData(string message, string owner = "Programmer")
	{
		Console.WriteLine("Error: {0}", message);
		Console.WriteLine("Owner of Error: {0}", owner);
	}
	
	/*
	One very important thing to be aware of, is that the value assigned to an optional parameter must be
known at compile time, and cannot be resolved at runtime (if you attempt to do so, you’ll receive
compile-time errors!).
This will not compile, as the value of the Now property of the DateTime class is resolved at runtime,
not compile time.
	*/
	/*
	static void EnterLogData2(string message,string owner = "Programmer", DateTime timeStamp = DateTime.Now)
	{
			
			Console.WriteLine("Error: {0}", message);
			Console.WriteLine("Owner of Error: {0}", owner);
			Console.WriteLine("Time of Error: {0}", timeStamp);
	}
	*/
}