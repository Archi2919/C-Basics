using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};

            //Add()
            numbers.Add(1);

            //AddRange
            numbers.AddRange(new int[3] { 5, 6, 8 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //IndexOf()
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            //LastIndexOf()
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            //Count()
            Console.WriteLine();
            Console.WriteLine("Count: " + numbers.Count);

            //Remove
            Console.WriteLine();
            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Clear
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
