using System;
using System.Text.RegularExpressions;

namespace NunitCoreAnagramNS
{
    
    public interface IAnagramChecker
    {
        bool IsAnagram(string word1, string word2);
    }
    
    public class AnagramChecker: IAnagramChecker
    {
        public string DeleteNonAlphanumericChars(string word)
        {
            return Regex.Replace(word, @"[^A-Za-z0-9]+", "");
        }
        public bool IsAnagram(string word1,string word2)
        {
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                return false;
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();
 
            Array.Sort(char1);
            Array.Sort(char2);
 
            string NewWord1 = DeleteNonAlphanumericChars(new string(char1));
            string NewWord2 = DeleteNonAlphanumericChars(new string(char2));

            if (NewWord1 == NewWord2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void Main()
        {/*
            string word1 = null;
            string word2 = null;
            Console.WriteLine(IsAnagram(word1, word2));
            */
        }
        
    }
}
