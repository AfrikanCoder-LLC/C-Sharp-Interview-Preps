using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures
{
    internal static class Numerics
    {
        public static int FindMissingNumberInArray(int[] inputArray)
        {
            int n = inputArray.Length + 1;
            int sumOfNNumbers = n * (n + 1) / 2;
            int sumOfInputArray = 0;
            foreach (int element in inputArray)
            {
                sumOfInputArray += element;
            }
            return sumOfNNumbers - sumOfInputArray;
        }

        public static int[] GenerateFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors.ToArray();
        }
    }
}
