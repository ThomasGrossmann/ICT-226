using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Add(int operande01, int operande02, int operande03)
        {
            return operande01 + operande02 + operande03;
            //TODO using a list of integer - NGY ;)
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
            float op1 = (float)operande01;
            float op2 = (float)operande02;
            return op1 / op2;
        }
        #endregion public methods
    }
}
