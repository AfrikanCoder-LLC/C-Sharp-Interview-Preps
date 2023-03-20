using System;
using System.Collections.Generic;
using System.Text;

namespace Answers
{
    public static class AlgorithmsAndDataStructures
    {
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
    }
}
