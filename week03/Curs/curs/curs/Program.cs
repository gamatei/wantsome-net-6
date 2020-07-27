using System;

namespace curs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 6, 4, 5, 2, 0, -1 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    Console.WriteLine($"Compar: {array[i]} cu {array[j]}. Poz: Array[{i}] cu array[{j}]");

                    if(array[i]>array[j])
                    {
                        var aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Array sortat!");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
        }

        /// <summary>
        /// Find all pairs of elements in an integer array, whose sum is equal to a given number        
        /// </summary>
        static void Ex2(int[] array, int sum)
        {
           for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[i]+array[j]==sum)
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} = {sum}");
                    }
                }
            }

        }


        /// <summary>
        /// check if 2 strings are anagrams
        /// LISTEN-SILENT
        /// TRIANGLE-INTEGRAL
        /// </summary>
        static void Ex7()
        {
            var result = Anagram("TRIANGLE", "INTEGRAL");
        }                                  

        static bool Anagram(string a, string b)
        {
            if (a.Length == b.Length)
            {
                char[] aCharArray = a.ToCharArray();
                char[] bCharArray = b.ToCharArray();
                Array.Sort(aCharArray);
                Array.Sort(bCharArray);
                
                for(int i=0;i<aCharArray.Length;i++)
                {
                    if(aCharArray[i]!=bCharArray[i])
                    {
                       return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Algoritm to find if Array contains duplicated?
        /// </summary>
        static void Ex4()
        {
            int[] array = new int[] { 2, 12, 16, 3, 15, 17, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("The array contains duplicates!");
                        return;
                    }

                }
            }
            Console.WriteLine("The array does not contain duplicates!");
        }

        //functie simpla
        //nu are input(nu are parametri)
        //nu are output(nu are return, "intoarce void"
        //void simpleFunction() - semnatura (nume functie+parametri)

        static void SimpleFunction()
        {
            if (DateTime.Now.Year == 2020)
            {
                return;
            }
            Console.WriteLine("Alt cod...");
        }


        //functie simpla
        //are input, un intreg
        //nu are output
        // SimpleFunction(int number) -semnatura
        static void SimpleFunction(int number)
        {

        }

        //functie
        //are input
        //dar are output, intoarce un tip
        //FuntionWithReturn(int a) - semnatura
        static int FunctionWithReturn(int a)
        {
            if (DateTime.Now.Year == 2020)
            {
                return -1;
            }
            Console.WriteLine("Alt cod...");
            return 2;
        }

        //functie
        //are input
        //dar are output, intoarce un tip
        //FuntionWithReturn(int a, int b) - semnatura
        //static int FunctionWithReturn(int a, int b)
        //{

        //}
    }
}
