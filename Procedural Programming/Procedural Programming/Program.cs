using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedural_Programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Example1();
            Example2();
            
        }

        public static void Example1()
        {
            Console.Write("What is your name?");
            var name = Console.ReadLine();

            string reversed = ReverseName(name);

            Console.WriteLine("Reversed Name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            return new string(array);
        }


        ///<summary>
        ///Exercise 2
        ///</summary>
        
        public static void Example2()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Eneter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in GetUniqueNumbers(numbers))
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;
        }
    }
}
