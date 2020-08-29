using System;
using System.Collections.Generic;//dictionary obj
using System.Linq; //Dictionary.Key method
using System.Text; //has String builder obj


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title: C# Letter Remover Practice
            //Purpose: Allows user to enter string and then lets to remove any character 
            //Author: Oleg Eremeev
            //Date: 2020 Aug 12

            //string runApp = true;

                //while (runApp = Console.ReadKey())
                //{            
            string result = "";
            Console.WriteLine("Please enter any string");         
            string source = Console.ReadLine();

            Console.WriteLine("Enter what you need to delete");
            string remove = Console.ReadLine();




              /*
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] != userChar[0])
                {
                    output += userInput[i];
                }
            }
            */

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == remove[0])
                {
                    source = source.Remove(i, 1);
                    i--;
                }
            }
            result = source;


            Console.WriteLine($"Your modified string is on the next line:\n{result}");

        }
    }
}
