using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        /// <summary>
        /// Find all pairs of elements in an integer array, whose sum is equal to a given number? [x]
        /// todo home: return the duplicates list as return type
        /// </summary>
        static void Ex2()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 9;
            List<Tuple<int, int>> pairs = Pairs(array, sum);
        }


        static List<Tuple<int, int>> Pairs(int[] array, int n)
        {
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == n)
                    {
                        pairs.Add(new Tuple<int, int>(array[i], array[j]));
                    }
                }
            }

            return pairs;
        }

        /// <summary>
        /// How to calculate factorial using recursion in C# + iterative + time difference.
        /// </summary>
        static void Ex3()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());
            var st1 = new Stopwatch();
            var st2 = new Stopwatch();
            int fact = 1;

            st1.Start();
            fact = FactIter(n);
            st1.Stop();

            st2.Start();
            fact = FactRec(n);
            st2.Stop();

            Console.WriteLine($"Factorialul lui {n} este {fact}");
            Console.WriteLine($" Timpii de executare sunt {st1.Elapsed} pentru iterative si {st2.Elapsed} pentru recursive");
        }


        static int FactIter(int n)
        {

            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static int FactRec(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * FactRec(n - 1);
        }


        /// <summary>
        /// How to find sum of digits of a number using Recursion?
        /// </summary>
        static void Ex5()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());

            int sum = DigitsSum(n);

            Console.WriteLine(sum);
        }

        static int DigitsSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return n % 10 + DigitsSum(n / 10);

        }

        /// <summary>
        /// Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?
        /// </summary>
        static void Ex6()
        {
            int[] array = new int[] { 1, 2, 5, 4, 5, 3, 5, 5, 7, 5, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                int freq = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        freq++;
                    }
                }
                if (freq > array.Length / 2)
                {
                    Console.WriteLine($" Numar majoritar este: {array[i]}");
                }
            }
        }

        /// <summary>
        /// Write a function to print the nth number in Fibonacci series?
        /// </summary>
        static void Ex8()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());

            long fibo = Fibo(n);

            Console.WriteLine($" The {n}th Fibonacci no is {fibo}");
        }

        static long Fibo(int n)
        {
            int previous = 0;
            int next = 1;
            int aux = 0;
            for (int i = 2; i <= n; i++)
            {
                aux = previous + next;
                previous = next;
                next = aux;
            }
            return next;
        }

        /// <summary>
        /// Write a function to count a total number of set bits in a 32-bit Integer?
        /// </summary>
        static void Ex9()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());
            int set = 0;

            Console.WriteLine($"The set bits for {n} is:");

            while (n != 0)
            {
                if (n % 2 == 1)
                {
                    set++;
                }
                n = n / 2;
            }

            Console.WriteLine(set);
        }

        /// <summary>
        /// Write a function to remove duplicate characters from String?
        /// </summary>
        static void Ex10()
        {
            Console.WriteLine("Please provide the string ");

            string initString = Console.ReadLine();

            for (int i = 0; i < initString.Length; i++)
            {
                for (int j = i + 1; j < initString.Length; j++)
                {
                    if (initString[i] == initString[j])
                    {
                        initString = initString.Remove(j, 1);
                    }
                }
            }

            Console.WriteLine(initString);
        }

        /// <summary>
        /// How to find the 3rd element from the end, in a singly linked, in a single pass?
        /// </summary>
        static void Ex11()
        {

        }


        /// <summary>
        /// C# program to check if a number is Armstrong number or not?
        /// </summary>
        static void Ex12()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());

            var arm = Armstrong(n);

            if (arm)
            {
                Console.WriteLine($"{n} is an Armstrong number!");
            }
            else
            {
                Console.WriteLine($"{n} is not an Armstrong number!");
            }

        }

        static bool Armstrong(int n)
        {
            int sum = 0;
            int temp = n;
            int digit = 0;

            while (temp != 0)
            {
                digit = temp % 10;
                sum = sum + (digit * digit * digit);
                temp = temp / 10;
            }

            return sum == n;

        }


        /// <summary>
        /// Algorithm to check if a number is Prime or not?
        /// </summary>
        static void Ex13()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());

            var prime = Prime(n);

            if (prime)
            {
                Console.WriteLine($"{n} is a prime number!");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number!");
            }
        }

        static bool Prime(int n)
        {
            if (n == 2)
            {
                return true;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Algorithm to check if a number is a Palindrome?
        /// </summary>
        static void Ex14()
        {
            Console.WriteLine("Please provide the no: ");

            int n = int.Parse(Console.ReadLine());

            var palindrome = Palindrome(n);

            if (palindrome)
            {
                Console.WriteLine($"{n} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{n} is not a palindrome!");
            }
        }

        static bool Palindrome(int n)
        {
            var temp = n;
            var pal = 0;

            while (temp != 0)
            {
                pal = (pal * 10) + (temp % 10);
                temp = temp / 10;
            }

            return pal == n;

        }


        /// <summary>
        /// Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?
        /// </summary>
        static void Ex15()
        {

        }


        /// <summary>
        /// How to rotate an array by a given pivot?
        /// </summary>
        static void Ex16()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] rotatedArray = new int[array.Length];
            int index = 0;

            Console.WriteLine($"Please provide a number between 0 and {array.Length - 1} ");
            int pivot = int.Parse(Console.ReadLine());

            for (int i = pivot; i < array.Length; i++)
            {
                rotatedArray[index] = array[i];
                index++;
            }
            for (int j = 0; j < pivot; j++)
            {
                rotatedArray[index] = array[j];
                index++;
            }
        }


        /// <summary>
        /// Sorting an Array using Selection Sort;
        /// </summary>
        static void Ex18()
        {
            int[] array = new int[] { 13, 16, 10, 2, 7, 1, 5, 11 };
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                    {
                        index = j;
                    }
                }
                if (i != index)
                {
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }
            }
        }
    }
}
