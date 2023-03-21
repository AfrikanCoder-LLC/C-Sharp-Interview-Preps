using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures
{
    public static class Arrays
    {
        public static bool CheckIfArrayHasDuplicateEntry(params int[] inputIntArray)
        {
            Dictionary<int, int> tempDictionary = new Dictionary<int, int>();
            foreach (int element in inputIntArray)
            {
                if (tempDictionary.ContainsKey(element))
                {
                    return true;
                }
                            
                tempDictionary.Add(element, 1);
            }
            return false;
        }
    }
}
