using System;
class params_array_demo
{
	/*
	The params keyword allows you to pass into a method a variable number of identically typed
parameters (or classes related by inheritance) as a single logical parameter. As well, arguments marked
with the params keyword can be processed if the caller sends in a strongly typed array or a commadelimited
list of items.
	*/
	static void Main()
	{
		double average;
		average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
		Console.WriteLine("Average of data is: {0}", average);
		// ...or pass an array of doubles.
		double[] data = { 4.0, 3.2, 5.7 };
		average = CalculateAverage(data);
		Console.WriteLine("Average of data is: {0}", average);
		// Average of 0 is 0!
		Console.WriteLine("Average of data is: {0}", CalculateAverage());
	}
	
	static double CalculateAverage(params double[] values)
	{
		Console.WriteLine("You sent me {0} doubles.", values.Length);
		double sum = 0;
		if(values.Length == 0)
		return sum;
		for (int i = 0; i < values.Length; i++)
		sum += values[i];
		return (sum / values.Length);
	}
}