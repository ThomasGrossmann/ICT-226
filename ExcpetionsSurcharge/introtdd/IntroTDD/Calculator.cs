using System;
using System.Collections.Generic;

namespace IntroTDD
{
    public class Calculator
    {
        #region constructors
        public Calculator()
        {
        }
        #endregion constructorsregion

        #region public methods
        public int Add(int operande01, int operande02)
        {
            return operande01 + operande02;
        }

        public int Add(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public int Sub(int operande01, int operande02)
        {
            return operande01 - operande02;
        }

        public int Mul(int operande01, int operande02)
        {
            return operande01 * operande02;
        }

        /// <summary>
        /// Doc : https://docs.microsoft.com/en-us/dotnet/api/system.math.round?view=netcore-3.1#Round1_Example
        /// </summary>
        public float Div(int operande01, int operande02, bool round = false)
    {
            float result;

            if (operande02 == 0)
            {
                throw new DivideByZeroException();
            }

            result = operande01 / (float)operande02;

            if (round)
            {
                result = (float)Math.Round(result, MidpointRounding.AwayFromZero);
            }
            return result;
        }
        #endregion public methods
    }
}
