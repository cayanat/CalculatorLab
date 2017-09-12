using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            string result="0";
            Stack rpnStack = new Stack();
            List<string> parts = str.Split(' ').ToList<string>();
            for (int i = 0; i < parts.Count; i++)
            {
                if (isNumber(parts[i]))
                {
                    rpnStack.Push(parts[i]);
                }
                if (isOperator(parts[i]))
                {
                    string Second = rpnStack.Pop().ToString();
                    string First = rpnStack.Pop().ToString();
                    result = calculate(parts[i], First, Second, 4);
                    rpnStack.Push(result);
                }
            }
            return result;
        }
    }
}
