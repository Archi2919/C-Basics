using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversion Example
            /*byte b = 1;
            int i = b;
            Console.WriteLine(i);*/

            //Explicit Type Conversion
            //int i = 1;
            //byte b = (byte)i; //(byte) this is a CAST, no data loss will happen as byte can store up to 255
            // Console.WriteLine(b);

            //Non-Compatible Type Conversion
            //try
            //{
            //    string number = "1234";
            //    int no = int.Parse(number);
            //    Console.WriteLine(no);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted.");
            //}

            try
            {
                string str = "true";
                bool boolean = Convert.ToBoolean(str);
                Console.WriteLine(boolean);
            }
            catch (Exception)
            {
                Console.WriteLine("Can not convert string to boolean");
            }
        }
    }
}
