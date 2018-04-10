using System;
class ref_params_demo
{
	static void Main()
	{
		string str1 = "Jack";
		string str2 = "Jill";
		Console.WriteLine("Before: {0}, {1} ", str1, str2);
		SwapStrings(ref str1, ref str2);
		Console.WriteLine("After: {0}, {1} ", str1, str2);
	}
	
	public static void SwapStrings(ref string s1, ref string s2)
	{
	string tempStr = s1;
	s1 = s2;
	s2 = tempStr;
	}
}