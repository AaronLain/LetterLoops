using System;
using System.Collections.Generic;


namespace LetterLoops
{
    class Program
    {
        static void LetterLoop(string input)
        {

            string[] letters = input.Split(",");
            List<string> printLetters = new List<string>();

            for (int i = 0; i < letters.Length; i++)
            {

                int count = i + 1;
                List<string> temp = new List<string>(); // creates new Array for each letter
                
                for (int j = 0; j < count; j++)
                {
                    if (j == 0)
                    {
                        temp.Add(letters[i].ToUpper()); // uppercases the first letter
                    }
                    else
                    {
                        temp.Add(letters[i]);
                    }
                }

                temp.Add("-"); // adds hyphen to the end of the array for style purposes
                printLetters.AddRange(temp);  // concats List temp with main list PrintLetters

            }
            
            string output = String.Join("", printLetters);
            Console.WriteLine($"{output}");

        }
        static void Main(string[] args)
        {

            string input;

            do
            {

                Console.WriteLine("Enter your letters or type 'exit':");
                input = Console.ReadLine();
                LetterLoop(input);

            } while (input != "exit" && input != "");
        }
    }
}
