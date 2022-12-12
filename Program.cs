using System;
using System.Linq;

namespace Tests {
    class TestApp
    {
        //Future dynamic method
        private static string[] AddAmountToArray(string[] array)
        {
            var arr = new string[array.Length * 2];
            return arr;
        }
        private static string[] GetArrayWithShortenedStrings(string[] arr, int numOfCharsMax)
        {
            
        }

        private static string[] GetInitialArray()
        {
            
        }
        static void Main()
        {
            var result = GetArrayWithShortenedStrings(GetInitialArray(), 3);

            Console.WriteLine("Result: ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    } 
}
