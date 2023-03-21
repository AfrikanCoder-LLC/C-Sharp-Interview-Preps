using System;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main()
        {
            //var output = Strings.RemoveDuplicateCharactersFromString("KKennittth");
            //var subStrings =
            //    Strings.GetAllPossibleSubstringsInAString("ken fukizi");

            //foreach (string subStr in subStrings)
            //{
            //    Console.WriteLine(subStr);
            //}
            //Console.WriteLine(Strings.CheckIfStringsAreAnagrams("spar", "rasp"));
            //Console.WriteLine(Strings.CheckIfAllCharactersInStringAreUnique("fukizi"));
            //Console.WriteLine(Strings.ReverseStringOrder("FUKIZI"));
            //Console.WriteLine(Strings.IsStringAPalindrome("sagas"));
            //Console.WriteLine(Strings.CountNumberOfWordsInSentence("This is just a test sentence"));
            
            int[] numArray = {3,5,7,7,9};
            Console.WriteLine(Arrays.CheckIfArrayHasDuplicateEntry(numArray));
            Console.WriteLine();
        }
    }
}
