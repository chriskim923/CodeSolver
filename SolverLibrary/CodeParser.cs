using System.Collections.Generic;

namespace SolverLibrary
{
    public static class CodeParser
    {
        public static List<string> ParseIntoBitStrings(string codeText, int bitStringLength)
        {
            var words = codeText.Split(' ');
            var bitStrings = new List<string>();
            foreach (string word in words)
            {
                for (var i = 0; i < word.Length; i += bitStringLength)
                {
                    if (i + bitStringLength <= word.Length)
                        bitStrings.Add(word.Substring(i, bitStringLength));
                    else bitStrings.Add(@"#");
                }
                bitStrings.Add("|");
            }
            bitStrings.RemoveAt(bitStrings.Count - 1);
            return bitStrings;
        }
    }
}
