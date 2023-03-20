using System;

namespace Answers
{
    class Program
    {
        static void Main()
        {
            //var output = AlgorithmsAndDataStructures.RemoveDuplicateCharactersFromString("KKennittth");
            var subStrings =
                AlgorithmsAndDataStructures.GetAllPossibleSubstringsInAString("abcdefgh");

            foreach (string subStr in subStrings)
            {
                Console.WriteLine(subStr);
            }
            //Console.WriteLine(output);
            Console.WriteLine();
        }
    }
}
