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

        public static int[] RotateArrayByPivot(int[] inputArray, int pivotIndex)
        {           
            pivotIndex %= inputArray.Length;
            //Rotate left part
            inputArray = Rotate(inputArray, 0, pivotIndex - 1);
            //Rotate right part
            inputArray = Rotate(inputArray, pivotIndex, inputArray.Length - 1);
            //Rotate all
            inputArray = Rotate(inputArray, 0, inputArray.Length - 1);

            return inputArray;
        }

        private static int[] Rotate(int[] inputArray, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                int temp = inputArray[startIndex];
                inputArray[startIndex] = inputArray[endIndex];
                inputArray[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
            return inputArray;
        }

        public static int[] MoveZerosToEndOfArray(int[] inputArray)
        {
            int currentPosition = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != 0)
                {
                    inputArray[currentPosition] = inputArray[i];
                    currentPosition++;
                }
            }
            for (int i = currentPosition; i < inputArray.Length; i++)
            {
                inputArray[i] = 0;
            }
            return inputArray;
        }        
    }
}
