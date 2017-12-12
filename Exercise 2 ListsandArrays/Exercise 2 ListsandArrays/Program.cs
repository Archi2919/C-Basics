using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_ListsandArrays
{
    class Program
    {
        
        static void Main(string[] args)
        {

           //Exercise1();
           //Exercise2();
           //Exercise3();
            Exercise4();
        }

        /// <summary>
        ///    When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        ///    If no one likes your post, it doesn't display anything.
        ///    If only one person likes your post, it displays: [Friend's Name] likes your post.
        ///    If two people like your post, it displays: [Friend 1]
        ///    and[Friend 2] like your post.
        ///    If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        ///     Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        private static void Exercise1()
        {
            var usersFriendsList = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter your friend's names and once you're finished, press enter when you're complete:");
                var userFriend = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userFriend))
                    break;

                usersFriendsList.Add(userFriend);
            }

            if (usersFriendsList.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} other like you post", usersFriendsList[0], usersFriendsList[1], usersFriendsList.Count - 2);
            }
            else if (usersFriendsList.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", usersFriendsList[0], usersFriendsList[1]);

            }
            else if (usersFriendsList.Count == 1)
            {
                Console.WriteLine("{0} likes your post", usersFriendsList[0]);
            }
            else
            {
                Console.WriteLine("You have nae pals");
            }
            Console.Read();
        }

        /// <summary>
        /// Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
        /// </summary>


        private static void Exercise2()
        {
            Console.WriteLine("Please enter your name: ");
            var userName = Console.ReadLine();

            var array = new char[userName.Length];
            for (var i = array.Length; i > 0; i--)
                array[userName.Length - i] = userName[i - 1];

            var reversedName = new string(array);
            Console.WriteLine("Your name revesered is: " + reversedName);

            Console.Read();
        }

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. 
        /// If a number has been previously entered, display an error message and ask the user to re-try. 
        /// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        /// </summary>

        private static void Exercise3()
        {
            List<int> numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Please enter a number");
                var input = Convert.ToInt32(Console.ReadLine());


                if (numbers.Contains(input))
                {
                    Console.WriteLine("Invalid number, please try again");
                    continue;
                }
                numbers.Add(input);
            }

            numbers.Sort();

            Console.WriteLine("The numbers in the list sorted is as follows:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }


        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        /// The list of numbers may include duplicates. 
        /// Display the unique numbers that the user has entered.
        /// </summary>


        private static void Exercise4()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number and when you have entered all the numbers and are happy type 'Quit'");
                var number = Console.ReadLine();
                if (number.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(number));
            }
            

            var unique = new List<int>();
            foreach (var number in numbers)
            {
                if(!unique.Contains(number))
                    unique.Add(number);
            }
            Console.WriteLine("The numbers in the list are: ");
            foreach (var number in unique)
            {
                Console.WriteLine(number);
            }
            Console.Read();
        }
    }
}
