using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithmetic operators
            /*var a = 1;
            var b = 2;
            var g = 3;

            Console.WriteLine(a + b * g);

            var c = 10;
            var d = 3;

            Console.WriteLine( c / d);

            //display the result with decimal need to cast to a float
            var e = 10;
            var f = 3;

            Console.WriteLine((float)e / (float)f);*/

            //Comparison Operators
            /*var a = 1;
            var b = 2;

            //Console.WriteLine(a > b);
            //Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a !=b)); // same as a==b*/

            //logical operators
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a); // true and false results to a false
            Console.WriteLine(c > b || c == a); //true because only one statement needs to be true
            Console.WriteLine(!(c > b || c == a)); //this equals false
        }
    }
}
