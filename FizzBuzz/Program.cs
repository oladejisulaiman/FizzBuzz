using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            FizzBuzz(array);
        }

        public static void FizzBuzz(int[] array)
        {
            string output;
            for (int i = 0; i < array.Length; i++)
            {
                output = "";
                if (array[i] % 3 == 0 || array[i] % 5 == 0)
                {
                    if (array[i] % 3 == 0)
                    {
                        output = "fizz";


                    }
                    if (array[i] % 5 == 0)
                    {
                        output += "buzz";

                    }
                    Console.WriteLine(output);
                }



            }



        }
    }
}
