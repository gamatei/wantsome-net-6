using System;

namespace week01Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = Console.ReadLine();
            string reversey = "";

            for (int i = y.Length; i >= 0; i--)
            {
                reversey = reversey + y[i];
            }
            Console.WriteLine(reversey);
        }

        public static void ex1(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void ex2(string[] args)
        {
            Console.WriteLine("Please provide the 1st no.");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the 2nd no.");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 != 0 && number2 != 0)
            {
                double div = Division(number1, number2);
                Console.WriteLine("Division result is: {0}", div);
            }
            else
            {
                Console.WriteLine("Not possible");
            }
            int multi = Multiplication(number1, number2);
            Console.WriteLine("Multiplication result is: {0}", multi);

            int min = Minim(number1, number2);
            Console.WriteLine("Minimul este : {0}", min);

            int max = Maxim(number1, number2);
            Console.WriteLine("Maximul este : {0}", max);

        }
        static double Division(int a, int b)
        {
            double c = (double)a / b;
            return c;
        }
        static int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }
        static int Minim(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int Maxim(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        static void Ex4(string[] args)
        {
            for (int i = 15; i <= 97; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        static void Ex5(string[] args)
        {
            for (int i = 20; i <= 65; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Ex6(string[] args
         {
            int a = 0;
            for (int i = 1400; i <= 2300; i++)
            {
                if (i % 7 == 0 && i % 5 == 0)
                {
                    a = a + 1;
                }
            }
            Console.WriteLine(a);
        }
        static void ex7(string[] args)
        {
            int x = new Random().Next(1, 10);

            while (Convert.ToInt32(Console.ReadLine()) != x)
            {
                Console.WriteLine("Wrong number, try again");
                Console.WriteLine(x);
            }
        }
    }
}

