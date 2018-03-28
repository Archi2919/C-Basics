using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgrammingExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        public static void Exercise2()
        {
            throw new NotImplementedException();
        }

        public static void Exercise1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            List<int> list = new List<int>();
            bool isConsecutive = IsConsecutiveNumbers(list);

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public static bool IsConsecutiveNumbers(List<int> list)
        {
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
