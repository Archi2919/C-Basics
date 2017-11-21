using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1UserEntersNumber
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>


            /*Console.WriteLine("Please enter a number between 1 and 10");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }*/

            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>


            /*Console.WriteLine("Please enter your first number");
            var userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            var userInput2 = Convert.ToInt32(Console.ReadLine());
            //this is the if else statement
            var max = (userInput1 > userInput2) ? userInput1 : userInput2;
            Console.WriteLine(max);
            */

            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>


            /*Console.WriteLine("Please enter a width of a pitcure");
            var width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a height of a picture");
            var height = Convert.ToDouble(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image Orientation is " + orientation);
            */

            /// <summary>
            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>

            Console.WriteLine("What is the speed limit in your area?");
            var speedLimit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the speed you were going in your car?");
            var carSpeed = Convert.ToDouble(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Your speed is OK, no need to panic! :)");
            }
            else
            {
                const int penaltyPoints = 5;
                var speedPoints = (carSpeed - speedLimit) / penaltyPoints;
                if (speedPoints > 12)
                {
                    Console.WriteLine("Your speed was ABSOLUTELY NOT ok, you've now lost your licience...... Unlucky");
                }
                else
                {
                    Console.WriteLine("Your speed is NOT OK, naughty person, you now have " + speedPoints + " on your licience");
                }
                
            }
        }

        public void Exercise2()
        {
            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            Console.WriteLine("Please enter your first number");
            var userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number");
            var userInput2 = Console.ReadLine();
            var userNumber1 = Convert.ToInt32(userInput1);
            var userNumber2 = Convert.ToInt32(userInput2);
            if (userNumber1 > userNumber2)
            {
                Console.WriteLine("Max is " + userNumber1);
            }
            else
            {
                Console.WriteLine("Max is " +userNumber2);
            }
        }

        public void Exercise3()
        {
            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>
            Console.WriteLine("Please enter a width of a picture");
            var width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a height of a picture");
            var height = Convert.ToDouble(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine(orientation);
        }

        public void Exercise4()
        {
            /// <summary>
            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>

            Console.WriteLine("What is the speed limit in your area?");
            var speedLimit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the speed you were going in your car?");
            var carSpeed = Convert.ToDouble(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Your speed is OK, no need to panic! :)");
            }
            else
            {
                const int penaltyPoints = 5;
                var speedPoints = (carSpeed - speedLimit)/penaltyPoints;
                if (speedPoints > 12)
                {
                    Console.WriteLine("Your speed was ABSOLUTELY NOT ok, you've now lost your licience...... Unlucky");
                }
                else
                {
                    Console.WriteLine("Your speed is NOT OK, naughty person, you now have " + speedPoints +
                                      " on your licience");
                }
            }

        }
    }
}
