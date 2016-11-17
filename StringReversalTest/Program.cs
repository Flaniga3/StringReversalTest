using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StringReversalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a string from the console
            Console.WriteLine("Enter Keegan's current favorite word: ");
            //Assign the user's entry to a variable
            string userInput = Console.ReadLine();
            //Show the string to the user
            Console.WriteLine($"Your string was: {userInput}");

            //Reverse the string
            string reversed = reverseString(userInput);

            Console.WriteLine($"Your reversed string is: {reversed}");

            //Wait for the user to look at the output to 
            Console.WriteLine("Press any key to end the program...");
            Console.ReadKey();
        }

        private static string reverseString(string input)
        {
            int stop = (input.Length/2);
            int x = 0;
            char[] reverseTmp = input.ToCharArray();

            while (x < stop)
            {
                reverseTmp[input.Length - 1 - x] = input[x];
                reverseTmp[x] = input[input.Length - 1 - x];
                x++;
            }

            return new string(reverseTmp);
        }
    }
}
