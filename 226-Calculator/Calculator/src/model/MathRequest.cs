using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// This class is designed to manage a mathematic request
    /// </summary>
    public class MathRequest
    {
        #region private attributes
        private int operand1;
        private char operatorChar;
        private int operand2;
        private int result;
        #endregion private attributes

        #region constructors
        public MathRequest (int op1, char ope, int op2)
        {
            this.operand1 = op1;
            this.operatorChar = ope;
            this.operand2 = op2;
        }

        #endregion constructors

        #region accessors and mutators
        /// <summary>
        /// This accessor delivers the value of op1
        /// </summary>
        public int Operand1
        { 
            get { return this.operand1; }
        }

        /// <summary>
        /// This accessor delivers the value of ope
        /// </summary>
        public char OperatorChar
        {
            get { return this.operatorChar; }
        }

        /// <summary>
        /// This accessor delivers the value of op2
        /// </summary>
        public int Operand2
        {
            get { return this.operand2; }
        }

        /// <summary>
        /// This mutator sets the value of result
        /// </summary>
        /// <returns></returns>
        public int Result
        {
            set { this.result = value; }
        }
        #endregion accessors and mutators

        #region public methods
        /// <summary>
        /// This public method gets the mathRequest (and its result if available)
        /// </summary>
        /// <returns>Return format is [op1] [ope] [op2] { = [result]}</returns>
        public override string ToString()
        {
            return this.operand1 + " " + this.operatorChar + " " + this.operand2 + " = " + this.result;
        }
        #endregion public methods
    }
}
