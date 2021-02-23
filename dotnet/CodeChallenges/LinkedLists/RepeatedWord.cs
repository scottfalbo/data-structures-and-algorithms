using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
using System.Text.RegularExpressions;

namespace Challenges
{
    public class RepeatedWord
    {
        /// <summary>
        /// Driver method
        /// </summary>
        /// <param name="input"> lengthy string phrase </param>
        /// <returns> first repeated word </returns>
        public static string RepeatWord(string input) =>
            FindRepeat(SplitString(input.ToLower()));
        
        /// <summary>
        /// Strip's all puncuation out of the string
        /// </summary>
        /// <param name="input"> orginal string </param>
        /// <returns> string with puncuation removed </returns>
        public static string StripPunctuation(string input) =>
            Regex.Replace(input, @"[^\w\s]", "");
        
        /// <summary>
        /// Splits the string into an array of words
        /// </summary>
        /// <param name="input"> original string </param>
        /// <returns> string[] of the individual words </returns>
        public static string[] SplitString(string input) => 
            StripPunctuation(input).Split(" ");

        /// <summary>
        /// Iterate over the array the words checking for repeats against a hashMap
        /// </summary>
        /// <param name="inputArray"> string[] of words </param>
        /// <returns> first word repeated, or null </returns>
        public static string FindRepeat(string[] inputArray)
        {
            HashMap<string> hashMap = new HashMap<string>(1024);
            foreach (var word in inputArray)
            {
                if (hashMap.Contains(word))
                    return word;
                else
                    hashMap.Set(word, word);
            }
            return null;
        }
        
    }
}
