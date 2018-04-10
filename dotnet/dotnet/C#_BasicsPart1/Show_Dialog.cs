using System.Windows.Forms;
using System;
class My_Cls
{
static void Main()
{
Console.WriteLine("Hello");
// Add this!
MessageBox.Show("Hello..again!!");
}
}
/*
At the command line, you must inform csc.exe which assembly contains the namespaces you are
using. Given that you have made use of the System.Windows.Forms.MessageBox class, you must specify
the System.Windows.Forms.dll assembly using the /reference flag

csc /r:System.Windows.Forms.dll TestApp.cs

*/