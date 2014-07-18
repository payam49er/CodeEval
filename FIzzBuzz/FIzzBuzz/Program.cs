///This code is written exclusively for CodeEval
///Challenge FizzBuzz https://www.codeeval.com/open_challenges/1/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{    
    class Program
    {

        static void Main(string[] args)
        {
            try
            {

                using (StreamReader reader = File.OpenText(args[0]))
                {

                    List<string[]> values = new List<string[]>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            var value = line.Split(',');
                            values.Add(value);
                        }

                    }

                    foreach (var lineOfnumber in values)
                    {
                        int A;
                        int.TryParse(lineOfnumber[0], out A);

                        int B;
                        int.TryParse(lineOfnumber[1], out B);

                        int N;
                        int.TryParse(lineOfnumber[2], out N);

                        for (int i = 1; i < N + 1; i++)
                        {
                            if (i%A == 0 && i%B == 0)
                                Console.Write("FB" + " ");
                            else if (i%A == 0)

                                Console.Write("F" + " ");

                            else if (i%B == 0)

                                Console.Write("B" + " ");

                            else

                                Console.Write(i + " ");

                        }

                        Console.WriteLine();
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(string.Format("Your input path is in correct \n" + e));
            }
        }
    }
}
