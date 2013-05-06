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

        /// <summary>
        /// Returns the count of instances of searchString found in the current string
        /// </summary>        
        public static int CountString(this string str, string searchString)
        {
            var tokens = str.Split(new[] { searchString }, StringSplitOptions.None);
            return tokens.Count() - 1;
        }

        public static string RemoveAllWhiteSpace(this string str)
        {
            return new string(str.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}
