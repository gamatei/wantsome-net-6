using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {



        }


        /// <summary>
        /// Read a number from the keyboard and

        ///-it is the temperature in C, convert it to F

        ///-it is the temperature in F, convert it to C

        ///-it is a number of days, convert it to years, months, weeks and days


        ///Conventions - year: 365 days, month: 30 days, week: 7 days, use only numbers

        ///bigger than 1000
        /// </summary>
        static void Ex3()
        {
            Console.WriteLine("Please provide the number: ");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine(" Is the no. the temp in C (press 1), The temp in F(press 2) or a no. of days(press 3) ? ");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    {
                        double f = Celsius2fahrenhiet(no);
                        Console.WriteLine($" The tempearture converted in Fahrenheit is: {f}");
                        break;
                    }
                case 2:
                    {
                        double c = Fahrenheit2celsius(no);
                        Console.WriteLine($" The tempearture converted in Celsius is: {c}");
                        break;
                    }
                case 3:
                    {
                        int y = years(no);
                        int dif = no - (y * 365);
                        int m = months(dif);
                        dif = dif - (m * 30);
                        int w = weeks(dif);
                        int d = dif - (w * 7);
                        Console.WriteLine($" The no converts in {y} years, {m} months, {w} weeks and {d} days");
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" This is not an option");
                        break;
                    }

            }
            //if (type == 1)
            //{
            //    double f = Celsius2fahrenhiet(no);
            //    Console.WriteLine($" The tempearture converted in Fahrenheit is: {f}");
            //}
            //else if (type == 2)
            //{
            //    double c = Fahrenheit2celsius(no);
            //    Console.WriteLine($" The tempearture converted in Celsius is: {c}");
            //}
            //else if (type == 3)
            //{
            //    int y = years(no);
            //    int dif = no - (y * 365);
            //    int m = months(dif);
            //    dif = dif - (m * 30);
            //    int w = weeks(dif);
            //    int d = dif - (w * 7);
            //    Console.WriteLine($" The no converts in {y} years, {m} months, {w} weeks and {d} days");
            //}
            //else
            //{
            //    Console.WriteLine(" This is not an option");
            //}


        }
        static double Celsius2fahrenhiet(double c)
        {

            double f = (c * 9) / 5 + 32;
            return f;
        }

        static double Fahrenheit2celsius(double f)
        {

            double c = (f - 32) * 5 / 9;
            return c;

        }

        static int years(int a)
        {
            int y = a / 365;
            return y;
        }

        static int months(int a)
        {
            int m = a / 30;
            return m;
        }

        static int weeks(int a)
        {
            int w = a / 7;
            return w;
        }

        /// <summary>
        /// Print numbers from 1 to 10 except 4 and 7.
        /// </summary>
        static void ex10()
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i != 4 && i != 7)
                    Console.WriteLine(i);
            }


        }

        /// <summary>
        /// Print the Fibonacci sequence from 0 to 50. (i.e. Exery next number is found by adding up those two before it: 0, 1, 1, 2, 3, 5, 8, 13, ..
        /// </summary>
        static void ex11()
        {

            int i = 0, j = 1, k = 0;
            while (j < 50)
            {
                Console.WriteLine(j);
                k = i + j;
                i = j;
                j = k;
            }

        }

        /// <summary>
        /// Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
        ///Test Data:
        ///Input the first number: 25
        ///Input the second number: 4
        ///Expected Output:
        ///25 + 4 = 29
        ///25 - 4 = 21
        ///25 x 4 = 100
        ///25 / 4 = 6
        ///25 mod 4 = 1
        /// </summary>
        static void Ex12()
        {

            Console.WriteLine("Please insert the 1st number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert the 2nd number");
            int number2 = int.Parse(Console.ReadLine());

            int addition = Addition(number1, number2);
            Console.WriteLine($"{number1} + {number2} = {addition}");

            int subtraction = Subtraction(number1, number2);
            Console.WriteLine($"{number1} - {number2} = {subtraction}");

            int multiplication = Multiplication(number1, number2);
            Console.WriteLine($"{number1} + {number2} = {multiplication}");

            if (number2 != 0)
            {
                int division = Division(number1, number2);
                Console.WriteLine($"{number1} / {number2} = {division}");
            }
            else
            {
                Console.WriteLine("Not possible");
            }

            int mod = Modulo(number1, number2);
            Console.WriteLine($"{number1} mod {number2} = {mod}");

        }

        static int Division(int a, int b)
        {
            int c = a / b;
            return c;
        }

        static int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }

        static int Addition(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static int Subtraction(int a, int b)
        {
            int c = a - b;
            return c;
        }

        static int Modulo(int a, int b)
        {
            int c = a % b;
            return c;
        }

        /// <summary>
        /// Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
        ///Test Data:
        ///Enter the number: 5
        ///Expected Output:
        ///5 * 0 = 0
        ///5 * 1 = 5
        ///5 * 2 = 10
        ///5 * 3 = 15
        ///....
        ///5 * 10 = 50
        /// </summary>
        static void Ex13()
        {
            Console.WriteLine("Please provide the number: ");
            int no = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int m = no * i;
                Console.WriteLine($"{no} * {i} = {m}");
            }
        }

        /// <summary>
        /// Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
        /// Test Data:
        /// Enter the First number: 10
        /// Enter the Second number: 15
        /// Enter the third number: 20
        /// Enter the four number: 30
        ///Expected Output:
        ///The average of 10 , 15 , 20 , 30 is: 18
        /// </summary>
        static void Ex14()
        {

            Console.WriteLine("Please insert the 1st number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert the 2nd number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert the 3rd number");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert the 4th number");
            int number4 = int.Parse(Console.ReadLine());

            int av = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($" the average of {number1} , {number2} , {number3} , {number4} is: {av}");

        }

        /// <summary>
        /// Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. Go to the editor
        /// Sample Output:
        /// Input a string : The quick brown fox jumps over the lazy dog.
        /// TThe quick brown fox jumps over the lazy dog.T
        /// </summary>
        static void Ex15()
        {
            Console.WriteLine("Please provide the text:");
            string sir = Console.ReadLine();
            string firstCar = sir.Substring(0, 1);
            string sirFinal = string.Concat(firstCar, sir, firstCar);
            //string sirFinal = firstCar + sir + firstCar;
            Console.WriteLine(sirFinal);


        }


        /// <summary>
        /// Write a C# program to compute the sum of the first 500 prime numbers. 
        /// Sample Output:
        /// Sum of the first 500 prime numbers:
        /// 3682913
        /// </summary>
        static void Ex16()
        {
            int primeNumbers = 0,
                currentNumber = 1,
                sum = 0;

            while (primeNumbers < 500)
            {
                currentNumber++;
                if (IsPrime(currentNumber))
                {
                    sum = sum + currentNumber;
                    primeNumbers++;
                }

            }
            Console.WriteLine($" The sum of the first 500 prime numbers is: {sum}");
        }
        static bool IsPrime(int a)
        {
            if (a == 2)
            {
                return true;
            }
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
