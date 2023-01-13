using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    /// <summary>
    /// Claculator class created to perform AO
    /// </summary>
    internal class Calculator
    {
        //instance variables
        public int first, second, result;
        public Calculator(int firstNum, int secondNum)
        {
            first = firstNum;
            second = secondNum;
        }
        /// <summary>
        /// Addition of 2 num to get result
        /// </summary>
        public void Addition()
        {
            result = first + second;
            Console.WriteLine("Sum:" + result);
        }
        public void Substraction()
        {
            result = Math.Abs(first + second);
            Console.WriteLine("diff:" + result);
        }
    }
}
