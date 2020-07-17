using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listGuess1 = new List<int>();
            List<int> listGuess2 = new List<int>();
            int x = new Random().Next(1, 10);
            int inserted = int.Parse(Console.ReadLine());
            int i = 0;

            while (inserted!=x)
            {
                if (inserted < 5)
                {
                    listGuess1.Add(inserted);
                }
                else
                {
                    listGuess2.Add(inserted);
                }
                i++;
            }
            Console.WriteLine($"You made {listGuess1.Count+listGuess2.Count} guesses");
        }


        static void Curs()
        {
            List<int> myList = new List<int>();
            myList.Add(4);
            myList.Add(7);
            myList.Add(8);

            List<int> myList1 = new List<int>();
            myList1.AddRange(myList);
            myList1.Add(9);
            bool result = myList1.Contains(4);

            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddFirst(1);
            myLinkedList.AddFirst(2);
        }

        static void Listnumber()
        {
            int startNumber = 1;
            int endNumber = 10;
            List<int> myList = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i != 4 && i != 7)
                {
                    myList.Add(i);
                }

            }
            string listToPrint = "";
            foreach (int x in myList)
            {
                listToPrint += $" {x} ";
            }
            Console.WriteLine(listToPrint);
        }


        static void Fibo()
        {
            int start = 0;
            int next = 1;
            int sum;

            List<int> fibo = new List<int>() { start, next };

            do
            {
                sum = start + next;
                fibo.Add(sum);
                start = next;
                next = sum;
            } while (start + next <= 50);

            string listToPrint = "";

            foreach (int x in fibo)
            {
                listToPrint += $"{x} ";
            }

            Console.WriteLine(listToPrint);

        }

        static void Remove()
        {
            List<int> noList = new List<int>() { 12, 3, 5, 7, 3, 16 };
            List<int> newList = new List<int>();

            bool threefound = false;
            for (int i = 0; i <= noList.Count - 1; i++)
            {
                if (noList[i] == 3 && !threefound)
                {
                    threefound = true;
                    continue;
                }

                newList.Add(noList[i]);
            }

            string listToPrint = "";
            foreach (int x in newList)
            {
                listToPrint += $"{x} ";
            }

            Console.WriteLine(listToPrint);

        }

        static void Minmax1()
        {
            List<int> myList = new List<int> { 16, 22, 5, 7, 36, 0 };
            int max = myList[0];
            int min = myList[0];
            for (int i = 1; i < myList.Count; i++)
            {
                if (max < myList[i])
                {
                    max = myList[i];
                }
                if (min > myList[i])
                {
                    min = myList[i];
                }
            }
            Console.WriteLine($"Min : {min} , Max: {max}");


     

        }

        static void Minmax2()
        {
            List<int> myList = new List<int> { 16, 22, 5, 7, 36, 0 };
            int max = myList.Max();
            int min = myList.Min();

            Console.WriteLine($"Min : {min} , Max: {max}");



        }
    }
}
