using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public void Insertion_Sort()
        {
            Console.WriteLine("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("Enter string elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();//array index by user input
            }
            for (int i = 1; i < array.Length; i++)
            {
                string temp = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(temp) > 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = temp;
            }
            Console.WriteLine("Printing Sorted Element List ...\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
