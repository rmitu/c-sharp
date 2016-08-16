using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 12, 4, 8, 120, 1656, 1, 0, -1 };
            Console.WriteLine("Unsorted");

            for (int i = 0; i < unsortedArray.Length; i++ )
            {
                Console.Write(unsortedArray[i]);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
            int[] sortedArray = BubbleSort(unsortedArray);

            Console.WriteLine("Bubble sorted");

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i]);
                Console.Write(" ");
            }

            Console.ReadLine();



        }

        private static int[] BubbleSort(int[] unsortedArray)
        {
            int length = unsortedArray.Length;
            for (int i = 0; i < length - 1; i++ )
            {
                for (int j = 0; j < length - 1 - i;  j++)
                {
                    if( unsortedArray[j] > unsortedArray[ j + 1] )
                    {
                        int num = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[ j + 1 ];
                        unsortedArray[j + 1] = num ;
                    }
                }
            }
            return unsortedArray;
        }
    }
}
