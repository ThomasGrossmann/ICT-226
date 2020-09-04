using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroTDD;

namespace TestIntroTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 2 + 4;
            int op1 = 2;
            int op2 = 4;
            char operatorChar = '+';
            Calculator calculator = new Calculator();

            //when
            actualResult = calculator.Add(op1, op2);

            //then
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
