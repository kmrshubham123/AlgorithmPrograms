using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSorting
    {
        public void BubbleSort()
        {
            Console.WriteLine("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size]; //create a array
            Console.WriteLine("enter string elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());//array index by user input
            }
            for (int i = 0; i < size; i++) //outer phase
            {
                for (int j = i + 1; j < size; j++) //inner phase
                {
                    if (array[j] > array[i])// sort 
                    {
                        int temp = array[i]; //swap
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Printing Sorted Element List ...\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }     
}   
