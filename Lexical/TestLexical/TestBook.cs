using System;
using System.Globalization;
using Lexical;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLexical
{
    [TestClass]
    public class TestBook
    {
        [TestMethod]
        public void ConcatenateTwoWordsSuccess()
        {
            //given
            string word1 = "roberto";
            string word2 = "carlos";
            string expectedResult = "Roberto Carlos";
            string actualResult = "";
            Book book = new Book();

            //when
            actualResult = book.Concatenate(word1, word2);

            //then
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
