using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    static class CodeParser
    {
        public static List<string> Split(string text, int codeLength)
        {
            var hashChar = '#';
            var leftoverCharsIndicator = hashChar.ToString();

            var words = text.Split(' ');
            var splitCode = new List<string>();
            foreach (string word in words)
            {
                for (var i = 0; i < word.Length; i += codeLength)
                    if (i + codeLength <= word.Length)
                        splitCode.Add(word.Substring(i, codeLength));
                    else splitCode.Add(leftoverCharsIndicator);
                splitCode.Add(" ");
            }
            return splitCode;
        }

        public static string Invert(string text, int codeBaseNumber)
        {
            return "inverted string";
        }

    }
}
