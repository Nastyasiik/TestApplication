using System;
using System.Linq;

namespace Tests {
    class TestApp
    {
        private static string[] GetArrayWithShortenedStrings(string[] arr, int numOfCharsMax)
        {
            return arr.Where(x => x.Length <= numOfCharsMax).ToArray();
        }

        private static string[] GetInitialArray()
        {
            Console.WriteLine("Hi, how many strings do you plan to enter?");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[n];

            Console.WriteLine($"Enter your {n} strings");
            for (int i = 0; i < n; i++)
            {
                var tmp = Console.ReadLine();
                input[i] = tmp is null ? "0" : tmp;
            }
            return input;
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
