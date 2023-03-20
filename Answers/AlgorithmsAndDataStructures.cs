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
            var tempString = string.Empty;

            foreach (char character in inputString)
            {
                var charIsnotInEmptyString = tempString.Contains(character) == false;
                if (charIsnotInEmptyString)
                {
                    tempString += character;
                    outputString += character;
                }
            }

            return outputString;
        }
    }
}
