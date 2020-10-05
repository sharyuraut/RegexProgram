using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Regex Program.");

            Program checkzip = new Program();
            Program checkmail = new Program();

            Console.WriteLine("Choose one option: \n 1.Check ZipCode \n 2. Check EmailId");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    checkzip.checkZipcode();
                    break;

                case 2:
                    checkmail.checkEmailid();
                    break;
            }

        }

        private void checkEmailid()
        {
            Console.WriteLine("Enter your EmailID: ");
            string EmailId = Console.ReadLine();
            string EmailPattern = "^([a-z]{1}[a-z 0-9]{0,}\\.{1}\\@{1})$";
            if (Regex.IsMatch(EmailId, EmailPattern))
                Console.WriteLine("valid EmailId ");
            else
                Console.WriteLine("Invalid EmailId.");
        }

        private void checkZipcode()
        {
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
