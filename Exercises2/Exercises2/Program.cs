using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            /// Display the result on the console.
            /// </summary>

            //int count = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine(count);

            /// <summary>
            /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            /// </summary>

            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number, or OK to exit ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The total(sum) of all your numbers you entered was: " + sum);

            /// <summary>
            /// Write a program which takes a single argument from the console, computes the factorial and prints the 
            /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            /// and display it as 5! = 120.
            /// </summary>

            //Console.WriteLine("Please enter a number: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for (var i = 1; i <= input; i++)
            //    factorial *= i;


            //Console.WriteLine("{0}! = {1}", input, factorial);

            /// <summary>
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            /// </summary>


            //var random = new Random();
            //var chosenNumber = random.Next(1, 10);
            //Console.WriteLine("Secret number is: " + chosenNumber);
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Can you guess the number?");
            //    var userNumber = Convert.ToInt32(Console.ReadLine());

            //    if (userNumber == chosenNumber)
            //    {
            //        Console.WriteLine("You Won!");
            //        return;
            //    }
            //}
            //Console.WriteLine("You lost!");

            /// <summary>
            /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            /// display 8 on the console.
            /// </summary>


            //Console.WriteLine("Please enter a series of numbers and seperated them by comma");

            //var input = Console.ReadLine();
            //var numbers = input.Split(',');

            //// Assume the first number is the max 
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //        max = number;
            //}

            //Console.WriteLine("Max is " + max);


        }

        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        public void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>

        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }


        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>

        public void Exercise3()
        {
            Console.WriteLine("Please enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (int i = 0; i < input; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0} = {1}", factorial, input);

        }
        ////<summary>
        ////Write a program and continuously ask the user to enter a number.The loop terminates when the user
        ///enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        ///</summary>

        public void Exercise4()
        {
            var random = new Random();
            var chosenNumber = random.Next(1, 10);
            Console.WriteLine("Secret is: " + chosenNumber);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Can you guess the number?");
                var userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == chosenNumber)
                {
                    Console.WriteLine("You Won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }

        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>
        public void Exercise5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }

    }
}
