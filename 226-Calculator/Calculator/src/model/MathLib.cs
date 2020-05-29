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
        private int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        /// <summary>
        /// This method is designed to substract one integer to another
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Result of the substraction, in integer</returns>
        private int Substract(int op1, int op2)
        {
            return op1 - op2;
        }

        /// <summary>
        /// This method is designed to multiply one integer with another
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Result of the multiplication, in integer</returns>
        private int Multiply(int op1, int op2)
        {
            return op1 * op2;
        }

        /// <summary>
        /// This method is designed to divide one integer with another
        /// </summary>
        /// <param name="op1">First operand</param>
        /// <param name="op2">Second operand</param>
        /// <returns>Result of the division, in integer</returns>
        private int Divide(int op1, int op2)
        {
            return op1 / op2;
        }

        /// <summary>
        /// This method is designed pour je sais pas quoi
        /// </summary>
        /// <param name="mathRequest"></param>
        public void ExecuteRequest(MathRequest mathRequest)
        {
            int result;
            switch (mathRequest.OperatorChar)
            {
                case '+':
                    result = Add(mathRequest.Operand1, mathRequest.Operand2);
                    break;
                case '-':
                    result = Substract(mathRequest.Operand1, mathRequest.Operand2);
                    break;
                case '*':
                    result = Multiply(mathRequest.Operand1, mathRequest.Operand2);
                    break;
                case '/':
                    result = Divide(mathRequest.Operand1, mathRequest.Operand2);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    result = 0;
                    break;
            }
            mathRequest.Result(result);
        }
    }
}