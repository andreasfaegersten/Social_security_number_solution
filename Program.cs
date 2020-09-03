using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Serialization;
using static System.Console;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string socialSecurityNumber;

            if (args.Length > 0)
            {
                socialSecurityNumber = args[0];
                Console.WriteLine($"You provided: {args[0]}");
            }
            else {}

            string firstName;
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            string surname;
            Console.Write("Please enter your surname: ");
            surname = Console.ReadLine();

            Console.Write("Please enter your social security number (YYMMDD-XXXX): ");
            socialSecurityNumber = Console.ReadLine();

            Console.Clear();

            string fullName = firstName + " " + surname;
            Console.WriteLine("Name: " + fullName);

            Console.WriteLine("Social Security Number: " + socialSecurityNumber);

            string gender;

            int genderNumber = int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1));
            
            bool isFemale = genderNumber % 2 == 0;

            gender = isFemale ? "Female" : "Male";

            DateTime birthDate = DateTime.ParseExact(socialSecurityNumber.Substring(0, 6), "yyMMdd", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;

            if ((birthDate.Month > DateTime.Now.Month) || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age--;
            }

            int generationYear = birthDate.Year;

            Console.WriteLine("Gender: " + gender + '\n' + "Age: " + age);

            if (generationYear <= 1945)
            {
                string silentGeneration = "Generation: Silent Generation (1928-1945)";
                Console.WriteLine(silentGeneration);
            }
            else if (generationYear >= 1946 && generationYear <= 1964)
            {
                string meGeneration = "Generation: Baby Boomers (1946-1964)";
                Console.WriteLine(meGeneration);
            }
            else if (generationYear >= 1965 && generationYear <= 1980)
            {
                string generationX = "Generation: X (1965-1980)";
                Console.WriteLine(generationX);
            }
            else if (generationYear >= 1981 && generationYear <= 1996)
            {
                string generationY = "Generation: Millenials (1981-1996)";
                Console.WriteLine(generationY);
            }
            else if (generationYear >= 1997 && generationYear <= 2012)
            {
                string generationZ = "Generation: Zoomers (1997-2012)";
                Console.WriteLine(generationZ);
            }
            else if (generationYear >= 2013)
            {
                string generationAlpha = "Generation: Alpha (2013-2020)";
                Console.WriteLine(generationAlpha);
            }
            else
            {
                Console.WriteLine("Generation: Unknown");
            }
            

            
        }
    }
}
