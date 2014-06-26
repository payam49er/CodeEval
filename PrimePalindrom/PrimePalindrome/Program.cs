using System;
using Microsoft.Win32;
using System.Runtime.Remoting.Messaging;
/// <summary>
/// https://www.codeeval.com/open_challenges/3/
/// This solution finds the biggest palindrome prime number less than 1000. 
/// This is a unique solution according CodeEval. 
/// All rights reserved, please do not copy and paste this code and submit it as your own.
/// Please contact me if you have a better solution. 
/// payam.shoghi@me.com
/// </summary>
namespace PrimePalindrome
{
	class MainClass
	{
	
		public static class PalindromPrime
		{
			public static bool IsPalindrome(int number)
			{
				int revised = 0;
				int n = number;
				while (number > 0)
				{
					var digit = number % 10;
					revised = revised * 10 + digit;
					number = number / 10;
				}
				return n == revised;
			}

			public static bool IsitPrime(int number)
			{
				//very basic primary check
			
				for (int i = 2; i < number; i++) {
					if (number % i == 0 && i != number)
						return false;
				}


				return true;
			}

		}



		public static void Main (string[] args)
		{

			int biggestNumber = 0;
			for (int i = 1000; i > 0; i--)
			{
				if (PalindromPrime.IsPalindrome (i) && PalindromPrime.IsitPrime (i)) {
					biggestNumber = i;
					break;
				}

			}

			Console.Write (biggestNumber);
			Console.Read ();

		}
	}
}
