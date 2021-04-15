using NUnit.Framework;
using NunitCoreAnagramNS;
using System;
namespace UnitTestProjectAnagram
{
    public class AnagramCheckerTest
    {
        AnagramChecker anagram = new AnagramChecker();

        [Test]
        public void FalseWhenWordsAreNull()
        {
            string word1 = null;
            string word2 = null;
            Assert.IsFalse(anagram.IsAnagram(word1, word2), "Words can't be null");
        }
        [Test]
        public void FalseWhenWordsAreEmpty()
        {
            string word1 = "";
            string word2 = "";
            Assert.IsFalse(anagram.IsAnagram(word1, word2), "Words can't be null");
        }

        [Test]
        public void IsTrueAlphaOnly()
        {
            string word1 = "cat";
            string word2 = "tac";
            Assert.IsTrue(anagram.IsAnagram(word1,word2),"Word {0} is anagram to {1}",word1,word2);
        }
        [Test]
        public void IsFalseAlphaOnly()
        {
            string word1 = "cat";
            string word2 = "tas";
            Assert.IsFalse(anagram.IsAnagram(word1, word2), "Word {0} is not anagram to {1}", word1, word2);
        }

        [Test]
        public void IsTrueNumericOnly()
        {
            string word1 = "1112";
            string word2 = "2111";
            Assert.IsTrue(anagram.IsAnagram(word1, word2), "Word {0} is anagram to {1}", word1, word2);
        }
        [Test]
        public void IsFalseNumericOnly()
        {
            string word1 = "123";
            string word2 = "122";
            Assert.IsFalse(anagram.IsAnagram(word1, word2), "Word {0} is not anagram to {1}", word1, word2);
        }

        [Test]
        public void IsTrueAlphaNumericOnly()
        {
            string word1 = "cat1112";
            string word2 = "21cat11";
            Assert.IsTrue(anagram.IsAnagram(word1, word2), "Word {0} is anagram to {1}", word1, word2);
        }
        [Test]
        public void IsFalseAlphaNumericOnly()
        {
            string word1 = "1cat23";
            string word2 = "12cat2";
            Assert.IsFalse(anagram.IsAnagram(word1, word2), "Word {0} is not anagram to {1}", word1, word2);
        }

        [Test]
        public void IsTrueNonAlphaNumeric1()
        {
            string word1 = "cat111 2";
            string word2 = "21 cat11";
            Assert.IsTrue(anagram.IsAnagram(word1, word2), "Word {0} is anagram to {1}", word1, word2);
        }
        [Test]
        public void IsTrueNonAlphaNumeric2()
        {
            string word1 = "cat111 2";
            string word2 = "21.cat11";
            Assert.IsTrue(anagram.IsAnagram(word1, word2), "Word {0} is anagram to {1}", word1, word2);
        }

        [Test]
        public void IsTrueUpperLowerCase1()
        {
            string word1 = "Cat1112";
            string word2 = "21cAt11";
            Assert.IsTrue(anagram.IsAnagram(word1, word2), "Word {0} is anagram to {1}", word1, word2);
        }
        [Test]
        public void IsTrueUpperLowerCase2()
        {
            string word1 = "1Cat23";
            string word2 = "12cat2";
            Assert.IsFalse(anagram.IsAnagram(word1, word2), "Word {0} is not anagram to {1}", word1, word2);
        }
    }
}
