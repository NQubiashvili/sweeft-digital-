using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_3
{
    class Program
    {

        public static bool CheckString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            Stack<char> brackets = new Stack<char>();

            foreach (var c in input)
            {
                if ( c == '(')
                    brackets.Push(c);
                else if ( c == ')')
                {
                    // bevri damxuravi frchxili
                    if (brackets.Count <= 0)
                        return false;

                    char open = brackets.Pop();

                }
            }

            // bevri gamxsneli frcxhili 
            if (brackets.Count > 0)
                return false;

            return true;
        }
    }
}


