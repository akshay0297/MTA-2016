//saved it as file1.cs
using System;
namespace nm1
{
public class calculate
{
	public static void disp()
	{
		Console.Write("This is the dll saying hi!!");
	}

}
}


/*
compile into a dll as:
csc /target:library file1.cs

*/