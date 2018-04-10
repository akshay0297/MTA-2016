using System;
class named_params
{
	/*
	Named arguments allow you to invoke a method by specifying parameter values in any order you
choose. Thus, rather than passing parameters solely by position (as you will do in most cases), you can
choose to specify each argument by name using a colon operator.

This feature is really helpful when you have a method that defines optional or default arguments
*/

	static void Main()
	{
		DisplayFancyMessage(message: "Red on White!",textColor: ConsoleColor.DarkRed,backgroundColor: ConsoleColor.White);
		DisplayFancyMessage(backgroundColor: ConsoleColor.Green,message: "Blue on Green",textColor: ConsoleColor.DarkBlue);
		//Positional args must always be listed before the named args in method call.
		//this is incorrect
		//DisplayFancyMessage(backgroundColor: ConsoleColor.Blue,textColor: ConsoleColor.DarkBlue,"Hello");
		//following is fine
		DisplayFancyMessage(ConsoleColor.Blue,backgroundColor: ConsoleColor.Yellow,message:"Hello");
	}
	static void DisplayFancyMessage(ConsoleColor textColor,ConsoleColor backgroundColor, string message)
	{
		// Store old colors to restore after message is printed.
		ConsoleColor oldTextColor = Console.ForegroundColor;
		ConsoleColor oldbackgroundColor = Console.BackgroundColor;
		// Set new colors and print message.
		Console.ForegroundColor = textColor;
		Console.BackgroundColor = backgroundColor;
		Console.WriteLine(message);
		// Restore previous colors.
		Console.ForegroundColor = oldTextColor;
		Console.BackgroundColor = oldbackgroundColor;
	}
	

}