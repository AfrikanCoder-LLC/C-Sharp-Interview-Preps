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
    
        public static bool CheckIfAllCharactersInStringAreUnique(string inputString)
        {
            Dictionary<char, int> stringDictionary = new Dictionary<char, int>();

            foreach (char character in inputString)
            {
                if (stringDictionary.ContainsKey(character))
                    return false;
                else
                    stringDictionary.Add(character, 1);
            }
            return true;
        }

        public static string ReverseStringOrder(string inputString)
        {
            string outputString = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                outputString += inputString[i];
            }                
            return outputString;
        }

        /// <summary>
        /// What is a palindrome? :
        /// a word, phrase, or sequence that reads the same backwards as forwards, e.g. madam or racecar.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsStringAPalindrome(string inputString)
        {
            int startIndex = 0;
            int endIndex = inputString.Length - 1;
            
            while (true)
            {
                if (startIndex > endIndex)
                {
                    return true;
                }
                char leftCharacter = inputString[startIndex];
                char rightCharacter = inputString[endIndex];
                if (char.ToLower(leftCharacter) != char.ToLower(rightCharacter))
                {
                    return false;
                }
                startIndex++;
                endIndex--;
            }
        }

        public static int CountNumberOfWordsInSentence(string sentence)
        {
            int wordCount = 0;

            //Remove all leading and trailing white-space characters
            sentence = sentence.Trim();
           
            if (sentence == string.Empty)
            {
                return wordCount;
            }
                
            foreach (string word in sentence.Split(' '))
            {
                wordCount++;
            }
                
            return wordCount;
        }
    }
}
