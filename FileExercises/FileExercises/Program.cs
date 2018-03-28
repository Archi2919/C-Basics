using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();            
        }

        private static void Exercise2()
        {

            var fileText = @"C\Users\Ryan Archibald\Documetns\Test.txt";
            string[] stringOfWords = fileText.Split(new Char[] { ' ' });

            int biggest = 0;
            int biggestIndex = 0;

            for (int i = 0; i < stringOfWords.Length; i++)
            {
                if (biggest < stringOfWords[i].Length)
                {
                    biggest = stringOfWords[i].Length;
                    biggestIndex = i;
                }
            }
            
            Console.WriteLine("Longest Word: " + biggestIndex);
            Console.Read();
        }

        private static void Exercise1()
        {
            var path = @"C:\Users\Ryan Archibald\Documents\Test.txt";

            StreamReader streamReader = new StreamReader(path);

            int count = 0;
            string delim = " ";
            string[] fields = null;
            string line = null;

            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                count += fields.Length;
            }

            streamReader.Close();
            Console.WriteLine("The word count is {0}", count);
            Console.Read();
        }
    }
}
