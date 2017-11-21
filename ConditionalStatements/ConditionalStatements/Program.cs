using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCusomter = true;

            //float price;
            //if (isGoldCusomter)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            //conditional statement
            float price = (isGoldCusomter) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            //Switch cases
            var season = Season.Winter;

            switch (season)
            {
                case Season.Winter:
                case Season.Summer:
                    Console.WriteLine("Sales!");
                    break;
                   
                default:
                    Console.WriteLine("There is no season!");
                    break;
            }

        }
    }
}
