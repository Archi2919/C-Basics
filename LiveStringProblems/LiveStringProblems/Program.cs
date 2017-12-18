using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStringProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program will take a big string and cut it shorter without cutting out a word.
            var sentence = "This is going to be a really really really really really long text.";
            //use the sentence and set the max word length to 25
            var summary =StringUtility.SummeriseText(sentence, 25);
            Console.WriteLine(summary);
            
        }
    }
}
