using System;
using System.Linq;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// Basic string manipulation exercises
    /// </summary>
    public class StringTests : ITest
    {
        public void Run()
        {
            // TODO
            // Complete the methods below

            AnagramTest();
            GetUniqueCharsAndCount();
        }

        private void AnagramTest()
        {
            var word = "stop";
            var possibleAnagrams = new string[] { "test", "tops", "spin", "post", "mist", "step" };
                
            foreach (var possibleAnagram in possibleAnagrams)
            {
                Console.WriteLine(string.Format("{0} > {1}: {2}", word, possibleAnagram, possibleAnagram.IsAnagram(word)));
            }
        }

        private void GetUniqueCharsAndCount()
        {
            var word = "xxzwxzyzzyxwxzyxyzyxzyxzyzyxzzz";

            // TODO
            // Write an algorithm that gets the unique characters of the word below 
            // and counts the number of occurrences for each character found

            for (int i = 0; i < word.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    // checking if two characters are equal
                    if (word[i] == word[j] && i != j)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.Write(word[i]);
                    int freq = word.Count(f => (f == word[i]));
                    Console.WriteLine(freq);
                }
            }

     
        }
    }

    public static class StringExtensions
    {
        public static bool IsAnagram(this string a, string b)
        {
            // TODO
            // Write logic to determine whether a is an anagram of b

            return a
           .OrderBy(c => c)
           .SequenceEqual(b.OrderBy(c => c));

            //return false;
        }
    }
}
