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
            Console.WriteLine("2.Bubble Sort");
            Console.WriteLine("3.Insertion Sort");
            Console.WriteLine("4.Merge Sort");
            Console.WriteLine("5.Anagram");
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
                case 2:
                    {
                        BubbleSorting sorting = new BubbleSorting();
                        sorting.BubbleSort();
                        break;
                    }
                case 3:
                    {
                        InsertionSort sort = new InsertionSort();
                        sort.Insertion_Sort();
                        break;
                    }
                case 4:
                    {
                        MergeSorting sorting = new MergeSorting();
                        sorting.MergeSort();
                        break;
                       
                    }
                case 5:
                    {
                        Anagram anagram = new Anagram();
                        anagram.Check();
                        break;
                    }
            }
        }
    }
}
