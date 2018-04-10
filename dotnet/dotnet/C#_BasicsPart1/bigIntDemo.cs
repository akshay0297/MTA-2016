using System;
using System.Numerics;
class bigIntDemo
{
static void Main()
{
	BigInteger biggy =
	BigInteger.Parse("9999999999999999999999999999999999999999999999");
	Console.WriteLine("Value of biggy is {0}", biggy);
	Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
	Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
	BigInteger reallyBig = BigInteger.Multiply(biggy,
	BigInteger.Parse("8888888888888888888888888888888888888888888"));
	Console.WriteLine("Value of reallyBig is {0}", reallyBig);
}
}

/*
Compilation: >csc /r:System.Numerics.dll bigIntDemo.cs
Execution: bigIntDemo, press enter.

*/
