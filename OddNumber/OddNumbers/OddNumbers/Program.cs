using System;

/// <summary>
/// Solution to https://www.codeeval.com/open_challenges/25/
/// Print the odd numbers from 1 to 99.
/// </summary>
namespace OddNumbers
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			for(int i= 1; i < 100; i++)
			{
				if(i %2 != 0)
					Console.WriteLine (i);
			}

			Console.Read ();
		}
	}
}
