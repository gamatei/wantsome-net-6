using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                //if (i % 3 == 0 && i % 5 == 0)
                //{
                //    Console.WriteLine("FizzBuzz");
                //}
                //else 
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    Console.WriteLine();
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }


            /// <summary>
            ///  Find the index of an element in an array.
            /// </summary>
            static void Homework11()
            {
                int[] array = new int[] { 7, 39, 75, 10, 40, 1, 73, 3 };
                Console.WriteLine("Please provide a number from the array: ");
                int n = int.Parse(Console.ReadLine());

                //int i = Array.IndexOf(array, n);
                //Console.WriteLine($"The index of {n} is {i}.");

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == n)
                    {
                        Console.WriteLine($"The index of {n} is {i}.");
                        break;
                    }
                }
            }


            /// <summary>
            /// Insert an element into an array at a specified position.
            /// </summary>
            static void Homework2()
            {
                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

                Console.WriteLine("Please provide the no. you would like to add");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"Please provide the position you would like the no added at (from 0 to {array.Length - 1})");
                int pos = int.Parse(Console.ReadLine());

                array[pos] = n;

                foreach (int x in array)
                {
                    Console.Write($" {x}");
                }
            }

            /// <summary>
            /// For all numbers from 1 to 1000, print the following:
            ///- If number is divisible by 3, print Fizz
            ///- If number is divisible by 5, print Buzz
            ///- If number is divisible by 3 and 5, print FizzBuzz
            ///- Otherwise, print the number
            /// </summary>
            static void Homework31()
            {
                for (int i = 1; i <= 1000; i++)
                {
                    //if (i % 3 == 0 && i % 5 == 0)
                    //{
                    //    Console.WriteLine("FizzBuzz");
                    //}
                    //else 
                    if (i % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            /// <summary>
            /// Write a program to count the frequency of each element in an array e. g. [1, 4, 5, 2, 1, 4, 3, 1, 2]
            /// should output: 1 - 3 times 4 - 2 times 5 - one time 2 - 2 times 3 - one time
            /// </summary>

            static void Homework32()
            {

                int[] array = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
                int valReset = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    int n = 1;
                    if (array[i] == valReset)
                    {
                        continue;
                    }
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            n++;
                            array[j] = valReset;
                        }

                    }
                    Console.WriteLine($"{array[i]} is used {n} time(s)");
                }
            }

            /// <summary>
            /// Read an array from the console and separate odd and even values into 2 arrays. 
            /// E.g.Number of elements in array: 3
            ///- element 1: 4
            ///- element 2: 3
            ///- element 3: 2
            /// Result: Odd array: [3] Even array: [4, 2]
            /// 
            /// </summary>

            static void Homework33()
            {
                Console.WriteLine("Please provide the array length: ");
                var n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                int[] odd = new int[n];
                int[] even = new int[n];
                int oddN = 0;
                int evenN = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($" Element {i + 1} :");
                    array[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        even[evenN] = array[i];
                        evenN++;
                    }
                    else
                    {
                        odd[oddN] = array[i];
                        oddN++;
                    }
                }
                //Array.Resize(ref even, evenN);
                //Array.Resize(ref odd, oddN);
                //Console.WriteLine($" Odd: [{string.Join(" ,", odd)}] , Even: [{string.Join(", ", even)}]");

            string oddS = "";
            string evenS = "";
            
            for (int x = 0; x < oddN; x++)
            {

                if (oddS != "")
                {
                    oddS += ", ";
                }
                oddS += $"{odd[x]}";
            }
            
            for (int x = 0; x < evenN; x++)
            {
                if (evenS != "")
                {
                    evenS += ", ";
                }
                evenS += $"{even[x]}";
            }
            Console.WriteLine($" Odd:[{oddS}], Even:[{evenS}]");
        }

            /// <summary>
            /// Find common elements between two arrays of integers.
            /// </summary>
            static void Homework41()
            {
                int[] array1 = new int[] { 12, 15, 44, 365, 124, 42 };
                int[] array2 = new int[] { 365, 10, 42, 3, 7, 12, 444 };
                string commonElements = "";

                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            commonElements += $" {array1[i]}";
                            break;
                        }
                    }
                }
                Console.WriteLine($" The common elements are: {commonElements}");
            }

            /// <summary>
            /// Implement an algorithm to determine if a string has all unique characters.
            /// </summary>
            static void Homework42()
            {
                Console.WriteLine("Please provide the string:");
                string st = Console.ReadLine();
                var unique = true;

                for (int i = 0; i < st.Length && unique; i++)
                {
                    for (int j = i + 1; j < st.Length && unique; j++)
                    {
                        if (st[i] == st[j])
                        {
                            Console.WriteLine("The characters are not unique!");
                            unique = false;
                            //return;
                        }
                    }
                }

            if (unique)
            {
                Console.WriteLine("The characters are unique!");
            }
        }

            /// <summary>
            /// Write code to remove duplicates from an unsorted linked list.
            /// </summary>
            static void Homework43()
            {
                List<string> list = new List<string>() { "1", "2", "a", "w", "1", "3", "4", "a", "a", "z" };

                //List<string> uniqueList = list.Distinct().ToList();

                //foreach( string x in uniqueList)
                //{
                //    Console.WriteLine(x);
                //}


                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i] == list[j])
                        {
                            list.RemoveAt(j);
                            j--;
                        }
                    }
                }

            foreach (string x in list)
            {
                Console.WriteLine(x);
            }
        }

            /// <summary>
            /// Write a function to check if a number is prime or not.
            /// </summary>
            static void Homework44()
            {
                Console.WriteLine("Please provide the number: ");
                int n = int.Parse(Console.ReadLine());
                bool prime = true;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (n == 2 || prime)
                {
                    Console.WriteLine($"{n} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{n} is not a prime number.");
                }
            }


            /// <summary>
            /// Check if a word is a palindrome
            /// </summary>
            static void Homework45()
            {
                Console.WriteLine("Please provide the word: ");
                string word = Console.ReadLine();
                bool pal = true;

            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    pal = false;
                    break;
                }
            }
            if (pal)
            {
                Console.WriteLine($"The word {word} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word {word} is not a palindrome");
            }
        }
    }
}
