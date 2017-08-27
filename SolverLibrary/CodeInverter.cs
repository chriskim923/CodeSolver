using System;
using System.Text;

namespace SolverLibrary
{
    public static class CodeInverter
    {
        public static string TryInvert(string codeText, int codeBaseNumber)
        {
            var bitValue = 0;
            var newBitValue = 0;
            StringBuilder invertedText = new StringBuilder();
            foreach (char c in codeText)
            {
                if (char.IsWhiteSpace(c))
                    invertedText.Append(" ");
                else if (Char.IsNumber(c) && (int)Char.GetNumericValue(c) < codeBaseNumber)
                {
                    bitValue = (int)Char.GetNumericValue(c);
                    newBitValue = codeBaseNumber - bitValue - 1;
                    invertedText.Append(newBitValue.ToString());
                }
                else
                {
                    return "";
                }
            }
            return invertedText.ToString();
        }
    }
}
