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
    }
}
