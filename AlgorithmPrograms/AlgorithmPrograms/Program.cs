using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to the Algorithm Programs****");
            Console.WriteLine("============================================================");
            Console.WriteLine("1.The Array returned two string functions are equal or not");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    String[] strOne = { "Hello", "Hi", "Bye-Bye" };
                    String[] strTwo = { "Hello", "Hi", "Bye-Bye" };
                    if (TwoStringFunction.CheckEquality(strOne, strTwo))
                    {
                        Console.WriteLine("Both strings are same");
                    }
                    else
                    {
                        Console.WriteLine("Both string are Not same");
                    }
                    break;
            }
        }
    }
}
