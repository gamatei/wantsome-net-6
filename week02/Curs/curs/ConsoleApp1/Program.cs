using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        /// <summary>
        /// reverse array
        /// </summary>
        static void Ex1()
        {
            var array = new int[5] { 1, 32, 3, 4, 5 };
            var newArray = new int[5];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int newPoz = array.Length - 1 - i;
                newArray[newPoz] = array[i];
            }
            array[array.Length - 1] = 0;
            foreach (int value in newArray)
            {
                Console.WriteLine(value);
            }
        }


        /// <summary>
        /// even no. from 1 to 10 in array
        /// </summary>
        static void Ex2()
        {
            int startNumber = 1;
            int endNumber = 10;
            int counter = 0;

            var array1 = new int[7];
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 2 == 0)
                {
                    array1[counter] = i;
                    counter++;
                }
            }
            foreach (int value in array1)
            {
                Console.WriteLine(value);
            }
        }
        /// <summary>
        /// Print no without 1 or 10
        /// </summary>
        static void Ex3()
        {
            var array = new int[] { 13, 1, 15, 7, 19 };
            foreach (int v in array)
            {
                if (v == 1 || v == 10)
                {
                    continue;
                }
                Console.WriteLine(v);
            }
        }

        /// <summary>
        /// average for an array
        /// </summary>
        static void Ex4()
        {
            var array = new int[5];
            Console.WriteLine("please provide 5 numbers separated by comma");
            string input1 = Console.ReadLine();
            string[] separatedNumbers = input1.Split(',');
            for (var input = 0; input <= 4; input++)
            {
                array[input] = int.Parse(separatedNumbers[input]);
            }
            var sum = 0;
            foreach (var nr in array)
            {
                sum = sum + nr;
            }
            double av = (double)sum / array.Length;
            Console.WriteLine($"the average is: {av}");
        }

        /// <summary>
        /// 
        ///max & min of array
        /// </summary>
        /// <param name="args"></param>
        static void Ex5(string[] args)
        {
            int[] array = new int[] { 20, 11, 45, 2, 62, 1 };
            int max = -1,
                min = int.MaxValue;
            foreach (int val in array)
            {
                if (val < min)
                {
                    min = val;

                }
                if (val > max)
                {
                    max = val;
                }

            }
            Console.WriteLine("max is: " + max);
            Console.WriteLine("min is: " + min);
        }


        /// <summary>
        /// 
        ///remove element from array
        /// </summary>
        static void Ex6()
        {
            int[] array = new int[] { 20, 11, 45, 2, 62, 1 };
            int pos = 2;
            for (int i = pos + 1; i <= array.Length - 1; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = 0;

            foreach (int val in array)
            {
                Console.WriteLine(val);

            }
        }

        /// <summary>
        /// find no. in array
        /// </summary>
        static void Ex7()
        {
            int indexFound = -1;
            int[] array = new int[] { 12, 7, 67, 69, 5 };
            int value = 69;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    indexFound = i;
                    break;
                }
            }
            Console.WriteLine($"Index found on position: {indexFound}");
        }

        /// <summary>
        /// copy elements of array in another array
        /// </summary>
        /// <param name="args"></param>
        static void Ex8()
        {
            int[] array = new int[] { 12, 7, 67, 69, 5 };
            int[] array1 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }
            foreach (int v in array1)
            {
                Console.WriteLine(v);
            }
        }

        /// <summary>
        /// find common elements in arrays
        /// </summary>
        static void Ex9()
        {
            int[] array1 = new int[] { 123, 5, 423, 6, 42, 444, 2, 3 };
            int[] array2 = new int[] { 5, 23, 7878, 333, 42, 1, 0, 444 };
            foreach (int valueFromFirstArray in array1)
            {
                foreach (int valueFromSecondArray in array2)
                {
                    if (valueFromFirstArray == valueFromSecondArray)
                    {
                        Console.WriteLine((valueFromSecondArray));
                        break;
                    }
                }
            }
        }

    }
}
