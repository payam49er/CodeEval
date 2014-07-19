using System;
using System.IO;
using System.Linq;

namespace StackRD
{
    class Program
    {
        public class MyStack
        {
            private int Top { get; set; }
            private int MaxSize { get; set; }
            private int[] StackArray { get; set; }
            public int Size { get; private set; }

            public MyStack(int s)
            {
                MaxSize = s;
                StackArray = new int[MaxSize];
                Top = -1;
                Size = s;
            }

            public void Push(int item)
            {
                StackArray[++Top] = item;
            }

            public int Pop()
            {
                return StackArray[Top--];
            }
 
        }
        
        public static void DoStack(string path)
        {
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            int[] array = line.Split(' ').Select(x => int.Parse(x)).ToArray<int>();
                            
                            var myarray = new MyStack(array.Count());
                            for (int i = 0; i < array.Length; i++)
                            {
                                myarray.Push(array[i]);
                            }

                            for (int i = 0; i < myarray.Size; i++)
                            {

                                var item = myarray.Pop();
                                if(i %  2 == 0)
                                Console.Write(item + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There is a problem\n"+ e);
            }
           
           
        }


        static void Main(string[] args)
        {
           Console.WriteLine("Please insert the path");
            var path = Console.ReadLine();
            DoStack(path);
            Console.Read();

        }
    }
}
