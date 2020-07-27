using System;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

namespace curs2
{
    class Program
    {

        // two-dimensional array
        static void TwodArray()
        {
            int[,] arr2d = new int[3, 2]{
                {1, 2},
                {3, 4},
                {5, 6}
            };
            var rows = arr2d.GetLength(0);
            var cols = arr2d.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr2d[i, j]} ");
                }
                Console.WriteLine();
            }
        }


//Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?
// pozitia unde avem element majoritar
// -1 in caz ca nu avem element majoritar
static int Ex6(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > array.Length / 2)
                {
                    return i;
                }
            }
            return -1;
        }
        //suma maxim 2 elemente
        //suma  minima 2 elemente
        static int[] MinMax(int[] array)
        {
            int min1 = array[0], min1pos = -1, min2 = array[0], max1 = array[0], max1pos = -1, max2 = array[0], sumMin = 0, sumMax = 0;
            int[] arrayMinMax = new int[2];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min1)
                {
                    min1 = array[i];
                    min1pos = i;
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min2 && min1pos != i)
                {
                    min2 = array[i];
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max1)
                {
                    max1 = array[i];
                    max1pos = i;
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > min2 && max1pos != i)
                {
                    max2 = array[i];
                }
            }
            sumMin = min1 + min2;
            sumMax = max1 + max2;
            arrayMinMax[0] = sumMin;
            arrayMinMax[1] = sumMax;

            return arrayMinMax;
        }

        //daca un datase de lungimeN
        //targetul e cu fiecare iteratie sa injumatatim datasetul ce urmeaza a fi scanat
        //devide et empera O(log(N))
        static void BinarySearch()
        {
            int[] array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int start = 0, end = array.Length;
            var elem = -1;
            var mid = array.Length / 2;
            var elemPos = -1;

            while (start <= end)
            {
                if (elem > array[mid])
                {
                    start = mid + 1;
                    mid = (end + start) / 2;
                }
                else if (elem < array[mid])
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                }
                else
                {
                    elemPos = mid;
                    break;
                }
            }
            Console.WriteLine($"Pozitia elementului este: {elemPos}.");
        }


        static void Main(string[] args)
        {
            BinarySearch();
        }
    }
}
