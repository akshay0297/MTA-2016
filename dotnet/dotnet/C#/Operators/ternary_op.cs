
using System;
class ternary_op
{
static void Main() 
{
	//determine the larger of two values
	int a=1000,b=200,c;
	c=(a>b)?a:b;
	Console.WriteLine(c+" is greater");
	
	//get absolute value of a number
	int val=-30;
	int absval = val < 0 ? -val : val;
	Console.WriteLine("absolute value of "+val+"="+absval);
	
// Prevent a division by zero using the ?.	
	int result;
	for(int i = -5; i < 6; i++) 
	{
	result = (i != 0) ? 100 / i : 0;
	Console.WriteLine("100 / " + i + " is " + result);
	}
}
}