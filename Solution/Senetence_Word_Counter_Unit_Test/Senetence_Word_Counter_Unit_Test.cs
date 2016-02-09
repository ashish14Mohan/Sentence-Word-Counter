using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Senetence_Word_Counter_Unit_Test
{
    [TestClass]
    public class Senetence_Word_Counter_Unit_Test
    {
        [TestMethod]
        public void SentenceWordWithCountWithValidSentence()
        {
            string input = "This is good to see you , good to know you";
            string expectedOutput = " \nthis-1\nis-1\ngood-2\nto-2\nsee-1\nyou-2\nknow-1";//We are seprating the word and no.of count by colon(-) and for nextLine by (\n).
            string actual = Sentence_Word_Counter_BAL.Sentence_Word_Counter.SentenceWordWithCount(input);
            Assert.AreEqual(expectedOutput, actual);
        }

        [TestMethod]
        public void SentenceWordWithCountWithBlank()
        {
            string input = "";
            string expectedOutput = "m";
            string actual = Sentence_Word_Counter_BAL.Sentence_Word_Counter.SentenceWordWithCount(input);
            Assert.AreEqual(expectedOutput, actual);
        }

        [TestMethod]
        public void SentenceWordWithCountWithSpecialCharacter()
        {
            string input = "This. is good. to see you , good to know you";
            string expectedOutput = " \nthis-1\nis-1\ngood-2\nto-2\nsee-1\nyou-2\nknow-1";//We are seprating the word and no.of count by colon(-) and for nextLine by (\n).
            string actual = Sentence_Word_Counter_BAL.Sentence_Word_Counter.SentenceWordWithCount(input);
            Assert.AreEqual(expectedOutput, actual);
        }
    }
}
