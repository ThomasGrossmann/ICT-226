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
        #endregion public methods
    }
}
