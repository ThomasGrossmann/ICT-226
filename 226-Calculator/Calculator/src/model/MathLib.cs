using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// This class is designed to be a mathematics library
    /// </summary>
    public class MathLib
    {
        /// <summary>
        /// This method is designed to add two integers
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>The result, in integer</returns>
        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        /// <summary>
        /// This method is designed to substract one integer to another
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Result of the substraction, in integer</returns>
        public int Substract(int op1, int op2)
        {
            return op1 - op2;
        }

        /// <summary>
        /// This method is designed to multiply one integer with another
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Result of the multiplication, in integer</returns>
        public int Multiply(int op1, int op2)
        {
            return op1 * op2;
        }

        /// <summary>
        /// This method is designed to divide one integer with another
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Result of the division, in integer</returns>
        public int Divide(int op1, int op2)
        {
            return op1 / op2;
        }
    }
}
