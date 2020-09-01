using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroTDD;

namespace TestIntroTDD
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void AddNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 6;
            int op1 = 4;
            int op2 = 2;
            Calculator calculator = new Calculator();

            //when
            actualResult = calculator.Add(op1, op2);

            //then
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod]
        public void SubNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 2;
            int op1 = 4;
            int op2 = 2;
            Calculator calculator = new Calculator();

            //when
            actualResult = calculator.Sub(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MulNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 8;
            int op1 = 4;
            int op2 = 2;
            Calculator calculator = new Calculator();

            //when
            actualResult = calculator.Mul(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DivNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 2;
            int op1 = 4;
            int op2 = 2;
            Calculator calculator = new Calculator();

            //when
            actualResult = calculator.Div(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
