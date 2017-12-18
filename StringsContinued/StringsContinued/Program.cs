using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ryan Archibald ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim()); //Whitespace at the end of the name is gone

            Console.WriteLine("To Upper: '{0}'", fullName.ToUpper()); //Puts all string to capital letters

            //When there is a whitespace we stop there.
            var index = fullName.IndexOf(' ');
            //starts at the start and goes to the index in the string
            var firstName = fullName.Substring(0, index);
            //takes the character after the index and goes to the end of the string
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            //replace method           
            Console.WriteLine(fullName.Replace("Ryan", "Ryan David"));

            if(String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            if(String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            string number = "25";
            var age = Convert.ToByte(number);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            Console.WriteLine(price.ToString("C0"));
        }
    }
}
