using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagram
    {
        /// <summary>
        /// Check method is use to check two strings are anagram or not
        /// </summary>
        public void Check()
        {
            Console.WriteLine("Enter The First String"); //user Input First string
            String FirstString = Console.ReadLine();
            Console.WriteLine("Enter The Second String");//user Input Second string
            String SecondString = Console.ReadLine();

            if (FirstString.Length == SecondString.Length)//comparing the both string length
            {
                int count = 0;
                char[] StringOne = FirstString.ToCharArray(); //string to array
                char[] StringTwo = SecondString.ToCharArray();
                Array.Sort(StringOne); //Sorting of array
                Console.WriteLine(StringOne);
                Array.Sort(StringTwo);
                Console.WriteLine(StringTwo);
                //traverse 0 to Length
                for (int var_i = 0; var_i < StringOne.Length; var_i++)
                {
                    if (StringOne[var_i] == StringTwo[var_i])
                    {
                        count++;
                    }
                }
                if (count == FirstString.Length)
                {
                    Console.WriteLine("===============");
                    Console.WriteLine("This is a Anagram");
                }
                else
                {
                    Console.WriteLine("===============");
                    Console.WriteLine("This is not a Anagram");
                }

            }
            else
            {
                Console.WriteLine("===============");
                Console.WriteLine("Enter String of Same Length");
            }
        }
    }
}
