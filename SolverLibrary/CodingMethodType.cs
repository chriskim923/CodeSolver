using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    public abstract class CodingMethodType
    {
        private string matchedLetter;

        public abstract int CodeLength{ get; }

        public abstract int CodeBase { get; }

        public abstract Dictionary<string, string> CodeKey { get; }

        public string DecodeText(string text)
        {
            var decodedCharacters = new List<string>();
            var parsedCode = CodeParser.Split(text, this.CodeLength);
            foreach (var codeGroup in parsedCode)
            {
                if (CodeKey.TryGetValue(codeGroup, out matchedLetter))
                {
                    decodedCharacters.Add(matchedLetter);
                }
                else if (String.IsNullOrWhiteSpace(codeGroup))
                    decodedCharacters.Add(" ");
                else decodedCharacters.Add("#");
            }
            var decodedString = String.Join("", decodedCharacters);
            return decodedString;
        }

        public string EncodeText()
        {
            return "will return encoded text";
        }
    }
}
