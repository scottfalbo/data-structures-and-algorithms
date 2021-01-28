using System;
using DataStructures;
using System.Text;

namespace Challenges
{
    public class MultiBracketValidation
    {
        /// <summary>
        /// Takes in a string and validates that all types of brackets open and close properly.
        /// Returns true : false.  Throws Arguement Exception is string is empty or has no brackets.
        /// </summary>
        /// <param name="input"> string to validate </param>
        /// <returns></returns>
        public static bool Validate(string input)
        {
            
            if (input.Length < 0) throw new ArgumentException("Your input string is empty");

            Stack<char> holder = new Stack<char>();
            bool noBrackets = true;

            foreach (char c in input)
            {
                if (c.Equals('(') || c.Equals('{') || c.Equals('['))
                {
                    holder.Push(c);
                    noBrackets = false;
                }  

                switch (c)
                {
                    case ']':
                        if (holder.IsEmpty()) return false;
                        if (holder.Peek() == '[') holder.Pop();
                        break;
                    case '}':
                        if (holder.IsEmpty()) return false;
                        if (holder.Peek() == '{') holder.Pop();
                        break;
                    case ')':
                        if (holder.IsEmpty()) return false;
                        if (holder.Peek() == '(') holder.Pop();
                        break;
                    default:
                        break;
                }
            }

            if (noBrackets) throw new ArgumentException("There are no brackets");
            if (!holder.IsEmpty()) return false;
            return true;
        }
    }
}
