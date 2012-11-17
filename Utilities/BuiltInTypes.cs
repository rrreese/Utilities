using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class BuiltInTypes
    {
        public static bool IsEven(this int number)
        {
            return number%2 == 0;
        }

        /// <summary>
        /// Replaces each character in matchChars witht he replacement token.
        /// </summary>
        public static string ReplaceAll(this string str, string matchChars, string replacementToken)
        {
            return matchChars.Aggregate(str, (current, matchChar) => current.Replace(matchChar.ToString(), replacementToken));
        }
    }
}
