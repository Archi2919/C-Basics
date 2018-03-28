using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6};
            var smallest = GetSmallests(numbers, 3);

            foreach (var number in smallest)
            {
                Console.WriteLine(number);
            }
        }

        private static List<int> GetSmallests(List<int> list, int count)
        {
            //this if statement is a useful technique in defensive programming
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in a list");
            //handle when the list is null
            if (list == null)
                throw new ArgumentNullException("list", "The list is null and should not be null");
            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                //list.Remove(min); this is a side effect!!
                buffer.Remove(min);
            }

            return smallests;
        }

        private static int GetSmallest(List<int> list)
        {
            //assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
