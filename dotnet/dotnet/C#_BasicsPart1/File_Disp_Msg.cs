//Save this File_Disp_Msg.cs

using System;
class TestApp
{
static void Main()
{
Console.WriteLine("Greetings");
// Use the ShowMessage class!
ShowMessage h = new ShowMessage();
h.Say();
}












/*
compile as 
csc /r:System.Windows.Forms.dll File_Disp_Msg.cs  File_Msg.cs

or 

csc /reference:System.Windows.Forms.dll File_Disp_Msg.cs  File_Msg.cs

or



You will notice only one exe getting created: File_Disp_Msg.exe (for the cs file that contains the main method)
Execute:
File_Disp_Msg, followed by enter
The sequence of the file names is immaterial in the compilation statement. It could be:
>csc /r:System.Windows.Forms.dll File_Msg.cs File_Disp_Msg.cs

Using the out switch as well:

csc /reference:System.Windows.Forms.dll /out:myexe.exe File_Msg.cs File_Disp_Msg.cs

You will get the exe with the name myexe.exe created.


*/
}