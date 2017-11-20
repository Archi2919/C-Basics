using System;
using ClassExample.Math;

namespace ClassExample
{

    class Program
    {
        static void Main(string[] args)
        {
            var ryan = new Person();
            ryan.FirstName = "Ryan";
            ryan.LastName = "Archibald";
            ryan.Introduce();

            var calc1 = new Calculator();
            var result = calc1.Add(4, 7);
            Console.WriteLine(result);


        }
    }
}
