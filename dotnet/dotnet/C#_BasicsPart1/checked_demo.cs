 using System;
 class checked_demo
    {
        static void Main(string[] args)
        {
			ProcessBytes();
        }
		
		static void ProcessBytes()
		{
		try
		{
			/*
			attempts to add two bytes, each of which has been assigned a value that is safely below the
maximum (255).
*/
		byte b1 = 100;
		byte b2 = 250;
		//without the checked keyword, the following line will not throw an exception, irrespective 
		//of an overflow happening
		//byte sum = (byte)(b1+b2);
		
		//with the checked keyword, the following statement will result in a runtime error
		byte sum = checked((byte)(b1+b2));
		Console.WriteLine("sum = {0}", sum);
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}
		}
    }
	