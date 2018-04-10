using System;
class String_Data
{
	static void Main()
	{
			string firstName = "Tom";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter o?: {0}", firstName.Contains("o"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("T", "S"));
			Console.WriteLine(firstName);
            string str = firstName.Insert(3, "my");
            Console.WriteLine(str);
            //remove all the chars starting from index 3 till the end
            Console.WriteLine("str after removing the characters:"+str.Remove(3));
			
			//string concatenation
			Console.WriteLine("New"+"Delhi");
			Console.WriteLine(string.Concat("Programming"," ","in"," ","C#"));
			
			//verbatim strings
			/*
			When you prefix a string literal with the @ symbol, you have created what is termed a verbatim string.
			Using verbatim strings, you disable the processing of a literal’s escape characters and print out a string
			as is.
			*/
			//the following statement will not work as it requires the use of escape seq to represent slash
			//Console.WriteLine("C:\MyApp\bin\Debug");
			Console.WriteLine(@"C:\MyApp\bin\Debug");
			//strings are immutable
			//here s2, does not undergo modification, infact a new string object, s2 is allocated on the heap
			//the previous one is garbage collected
			string s2 = "My other string";
			s2 = "New string value";
			Console.WriteLine(s2);

			
	}
}