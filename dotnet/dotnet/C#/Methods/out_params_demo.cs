using System;
class out_params_demo
{
	static void Main()
	{
		int n,m;
		
		Add(10,5, out n,out m);
		Console.WriteLine("10 + 5 = {0}", n);
		Console.WriteLine("10 * 5 = {0}", m);
		int x; string y; bool z;
		FillTheseValues(out x, out y, out z);
		Console.WriteLine("x={0}",x);
		Console.WriteLine("y={0}",y);
		Console.WriteLine("z={0}",z);
		Console.ReadLine();
	}
	static void Add(int x, int y, out int ans1, out int ans2)
	{
	ans1 = x + y;
	ans2 = x*y;
	}
	/*
	the C# out modifier does serve a very
useful purpose: it allows the caller to obtain multiple outputs from a single method invocation.
	*/
	// Returning multiple output parameters.
	static void FillTheseValues(out int a, out string b, out bool c)
	{
	a = 10;
	b = "This is the string.";
	c = true;
	}
}