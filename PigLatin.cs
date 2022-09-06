using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bezao_technical
{
    public class PigLatin
    {
        // static void Main(string[] args)
        public static void generatePigLatin(string str)
        {
            // Push words in string into a list
            // for each word in the list, return characters after the first character
            // concatenate chars with the first character and "ay" 

            string[] words = str.Split(' ');
            List<string> list = new List<string>(words);
            string pgLatin = "";
            foreach (string item in list)
            {
                pgLatin += $"{item.Substring(1)}{item[0]}ay ";
            }
            Console.WriteLine(pgLatin);
        }
    }
}