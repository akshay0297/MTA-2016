using System;
class Implicit_Vars
{
	static void Main()
	{
		DeclareImplicitVars();
	}
	static void DeclareImplicitVars()
	{
	// Implicitly typed local variables.
	var myInt = 0;
	var myBool = true;
	var myString = "Hello...";
	// Print out the underlying type.
	Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
	Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
	Console.WriteLine("myString is a: {0}", myString.GetType().Name);
	}
}