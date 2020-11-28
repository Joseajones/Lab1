using System;
using System.Text.RegularExpressions;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           
         
            Console.Write("Welcome, please create a password for your secret recipe where the following criteria must be met: " +
            "\nYour password must contain: \nAt least one lower case letter \nAt least one uppercase letter \nAt least minimun 7 charaters " +
            "\nAt least maximum 12 charater \nAn exclamation point : ! \n\nPlease enter your password here:  ");
            
            string Password = Console.ReadLine();
            bool criteriaNotMet = false;

            if (!string.IsNullOrWhiteSpace (Password))
            {
                criteriaNotMet = (!Regex.IsMatch(Password, @"([a-z])")) ? true : criteriaNotMet;

                criteriaNotMet = (!Regex.IsMatch(Password, @"([A-Z])")) ? true : criteriaNotMet;

                criteriaNotMet = (!Regex.IsMatch(Password, @"([0-9])")) ? true : criteriaNotMet;

                criteriaNotMet = (!Password.Contains("!")) ? true : criteriaNotMet;

                criteriaNotMet = (Password.Length < 7) ? true : criteriaNotMet;

                criteriaNotMet = (Password.Length > 12) ? true : criteriaNotMet;

            }
            else
            {
                criteriaNotMet = true;
            }

            if (criteriaNotMet)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Password valid and accepted");
            }

            Console.ReadLine();
           
        } 
        
    } 
}
