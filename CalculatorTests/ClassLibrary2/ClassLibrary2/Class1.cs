using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        #region constructors
        public Calculator()
        {
        }
        #endregion constructors

        #region public methods
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Substract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int Multiply(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public int Divide(int operand1, int operand2)
        {
            return operand1 / operand2;
        }
        #endregion public methods
    }
}
