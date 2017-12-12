using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new int[]{1, 23, 4, 5, 6, 9, 100};

            //Length property
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf() method
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear() method
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear method:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy() method
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy");
            foreach (var i in another)
            {
                Console.WriteLine(i);
            }

            //Sort() method
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort");
            foreach (var  n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse Method()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
