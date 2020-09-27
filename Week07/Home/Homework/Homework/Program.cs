using System;
using System.Collections.Generic;
using System.IO;

namespace Homework
{    
    class Program
    {
        static void Main(string[] args)
        {
            /// ex 1
            try
            {
                Console.WriteLine("please enter full path of file:");
                var path = Console.ReadLine();
                string text = File.ReadAllText(path);
                Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The file has not been found.");
            }
                                    
            catch (PathTooLongException)
            {
                Console.WriteLine("The path you entered is too long.");
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("The Path is not in a valid format.");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access to file.");
            }                        
        }       
    }

}

