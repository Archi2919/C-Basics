using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    //random numbers between a range
            //    Console.WriteLine(random.Next(1, 10));
            //}

            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    //random numbers between a range
            //    Console.Write((char)('a' + random.Next(0, 26)));
                
            //}
            //Console.WriteLine();

            var random = new Random();

            const int passworLength = 10;

            var buffer = new char[passworLength];
            for (var i = 0; i < passworLength; i++)
                //random numbers between a range
                buffer[i] = (char) ('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
