using System;
using System.Collections.Generic;
using System.Text;

namespace Answers
{
    public static class AlgorithmsAndDataStructures
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string RemoveDuplicateCharactersFromString(string inputString)
        {
            var outputString = string.Empty;
            
            foreach (char character in inputString)
            {
                var charIsnotInEmptyString = outputString.Contains(character) == false;
                if (charIsnotInEmptyString)
                {                   
                    outputString += character;
                }
            }

            return outputString;
        }
        
        public static List<string> GetAllPossibleSubstringsInAString(string inputString)
        {
            List<string> substringList = new List<string>();           
            // Start with index 1, not 0, to avoid empty outputs.
            for (int length = 1; length < inputString.Length; length++)
            {
                for (int start = 0; start <= inputString.Length - length; start++)
                {
                    string substring = inputString.Substring(start, length);
                    substringList.Add(substring);                   
                }
            }
            return substringList;
        }

        /// <summary>
        /// What is an anagram? : 
        /// a word, phrase, or name formed by rearranging the letters of another, such as spar, formed from rasp.
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        public static bool CheckIfStringsAreAnagrams(string firstString, string secondString)
        {             
            char[] firstStringChars = firstString.ToLower().ToCharArray();
            char[] secondStringChars = secondString.ToLower().ToCharArray();
             
            Array.Sort(firstStringChars);
            Array.Sort(secondStringChars);
             
            string sortedFirstString = new string(firstStringChars);
            string sortedSecondString = new string(secondStringChars);
             
            if (sortedFirstString == sortedSecondString)
            {
                return true;
            }            
            return false;
        }
    }
}
