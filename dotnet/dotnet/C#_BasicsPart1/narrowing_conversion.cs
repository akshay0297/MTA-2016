 using System;
 class narrowing_conversion
    {
        static void Main(string[] args)
        {
			NarrowingAttempt();
			ProcessBytes();
        }
		static void NarrowingAttempt()
		{
		byte myByte = 0;
		int myInt = 200;
		//compile error
		/*
		Here, the value contained within the int variable (myInt) is safely within the range of a byte;
		therefore, you would expect the narrowing operation to not result in a runtime error. However, given
		that C# is a language built with type safety in mind, we do indeed receive a compiler error.
		*/
		//myByte = myInt;
		
		//explicit cast needed
		myByte=(byte)myInt;
		Console.WriteLine("Value of myByte: {0}", myByte);
		}
		static void ProcessBytes()
		{
		byte b1 = 100;
		byte b2 = 250;
		byte sum = (byte)(b1+b2);
		// sum should hold the value 350. However, we find the value 94!
		/*
				If you were to view the output of this application, you might be surprised to find that sum contains
		the value 94 (rather than the expected 350). The reason is simple. Given that a System.Byte can hold a
		value only between 0 and 255 (inclusive, for a grand total of 256 slots), sum now contains the overflow
		value (350 – 256 = 94).This is data loss, the expected result was 350, what has been obtained is 94.
		*/
		Console.WriteLine("sum = {0}", sum);
		}
		
    }
	