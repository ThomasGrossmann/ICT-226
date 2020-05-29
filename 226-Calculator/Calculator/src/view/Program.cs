using System;
using Model;

namespace Calculator
{
    /// <summary>
    /// This class is designed to be a Calculator
    /// Ref : https://www.w3schools.com/cs/cs_user_input.asp
    /// Ref : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static
    /// Ref : https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netcore-3.1
    /// Ref : https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
    /// Ref : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
    /// </summary>
    class Program
    {
        #region Variables declaration
        static private MathRequest mathRequest;
        static private MathLib mathLib;
        #endregion Variables declaration

        /// <summary>
        /// This method is the entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static private void Main(string[] args)
        {

            mathLib = new MathLib();

            do
            {
                mathRequest = AskForUserInput();
                mathLib.ExecuteRequest(mathRequest);
                Console.WriteLine("Your request                : " + mathRequest.ToString() + "\r\n");
                
                AskUserToContinue();

            }while (true);
        }

        #region User input and variable initialization
        /// <summary>
        /// This method asks the user to input both operandes and operator
        /// </summary>
        static private MathRequest AskForUserInput()
        {
            Console.Write("**********************\r\n");

            MathRequest mathRequest = null;

            Console.Write("Enter first operand         : ");
            int op1 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter operator (+, -, *, /) : ");
            char ope = char.Parse(Console.ReadLine());

            Console.Write("Enter second operand        : ");
            int op2 = int.Parse(Console.ReadLine());

            return mathRequest = new MathRequest(op1, ope, op2);
        }

        /// <summary>
        /// This method asks the user "do you want to continue or quit the application ?"
        /// </summary>
        static private void AskUserToContinue()
        {
            Console.Write("**********************\r\n");

            Console.Write("Escape to stop. Any key to continue !\r\n");
            ConsoleKeyInfo userChoice = Console.ReadKey();
            if (userChoice.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Bye... see you next time !");
                Environment.Exit(0);
            }
        }
        #endregion User input and variable initialization

    }
}
