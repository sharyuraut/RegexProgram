
using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Regex Program.");

            Console.WriteLine("Enter ZIP Code: ");
            string zipcode = Console.ReadLine();
            string zipPattern = "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$";
            if (Regex.IsMatch(zipcode, zipPattern))
                Console.WriteLine("valid ZIP Code: " + zipcode);
            else
                Console.WriteLine("Invalid ZIP Code.");
        }
    }
}