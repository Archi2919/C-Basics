using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStringProblems
{
    public class StringUtility
    {
        public static string SummeriseText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            //to store each word in alist before checking the length
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                //add current word to the list
                summaryWords.Add(word);

                //check if the total number of characters is over 20 and if so come out the loop
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            //create a string and joing the words using whitespace


            return String.Join(" ", summaryWords) + "..."; ;

        }
    }
}
