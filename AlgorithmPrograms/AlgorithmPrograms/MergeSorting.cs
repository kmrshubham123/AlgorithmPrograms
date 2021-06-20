using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSorting
    {
        public void MergeSort()
        {
            Console.WriteLine("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter integer elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(array, 0, size - 1);
            Console.WriteLine("======Sorted Array======");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
        /// <summary>
        /// mid is calculated as the mid point of the array. 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstValue"></param>
        /// <param name="lastValue"></param>
        /// <returns></returns>
        public static void Sort(int[] array, int firstValue, int lastValue)
        {
            if (lastValue > firstValue)
            {
                int mid = (firstValue + lastValue) / 2;

                Sort(array, firstValue, mid);
                Sort(array, mid + 1, lastValue);

                Merge(array, firstValue, mid, lastValue);
            }
           
        }
        /// <summary>
        /// merge is called that merges these sub-arrays.
        /// function basically merges these subarrays 
        /// into a single array in such a manner that the resultant array is also sorted
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstValue"></param>
        /// <param name="mid"></param>
        /// <param name="lastvalue"></param>
        public static void Merge(int[] array, int firstValue, int mid, int lastvalue)
        {
            int size1 = mid - firstValue + 1; //defining Size of the array
            int size2 = lastvalue - mid;

            int[] firstArray = new int[size1];// create sub-array 
            int[] secondArray = new int[size2];

            for (int i = 0; i < size1; i++)
            {
                firstArray[i] = array[firstValue + i];
            }
            for (int j = 0; j < size2; j++)
            {
                secondArray[j] = array[mid + 1 + j];
            }

            int x = 0, y = 0;
            int k = firstValue;
            while (x < size1 && y < size2)
            {
                if (firstArray[x] > secondArray[y])
                {
                    array[k] = secondArray[y];
                    y++;
                }
                else
                {
                    array[k] = firstArray[x];
                    x++;
                }
                k++;
            }
            while (x < size1)
            {
                array[k] = firstArray[x];
                x++;
                k++;
            }
            while (y < size2)
            {
                array[k] = secondArray[y];
                y++;
                k++;
            }
        }
    }
}
