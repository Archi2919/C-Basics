using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Ryan";
            var lastName = "Archibald";
            string myName = "Ryan";

            Int32 i;
            int j;

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is: {0} {1}", firstName, lastName);

            var names = new string[3] {"Jack", "Harris", "Ryan"};
            var formattedNames = String.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi Ryan
                        Look into the following paths
                        c:\fodler1\folder2
                        c:\fodler3\folder4";
            Console.WriteLine(text);

        }
    }
}
