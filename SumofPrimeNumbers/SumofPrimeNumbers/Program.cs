///This challenge is to determine the sum of the first 1000 prime numbers.
/// https://www.codeeval.com/open_challenges/4/
using System;
using System.Collections.Generic;
using System.Linq;

namespace SumofPrimeNumbers
{
    class Program
    {
        public static bool PrimeNumbers(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number%i == 0 && number != i)
                    return false;
            }

            return true;
        }



        static void Main(string[] args)
        {
            int counter = 0;
            List<int> primeNumbers = new List<int>();
          
                for (int i = 2;; i++)
                {
                    if (PrimeNumbers(i))
                    {
                        counter++;
                        primeNumbers.Add(i);
                    }
                    else if(counter == 1000)
                        break;
                }
            
           

            Console.Write(primeNumbers.Sum());
            Console.Read();

        }
    }
}
