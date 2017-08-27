using System;
using System.Collections.Generic;
using System.Text;

namespace SolverLibrary
{
    public class CodeDecoder
    {
        private readonly List<CodingMethod> codingMethods;

        public CodeDecoder()
        {
            codingMethods = new List<CodingMethod>();
            codingMethods.Add(new FrancisBaconv1());
            codingMethods.Add(new FrancisBaconv2());
            codingMethods.Add(new BinaryA00001());
            codingMethods.Add(new TernaryA001());
            codingMethods.Add(new HexA01());
            codingMethods.Add(new ASCIIHexA41());
            codingMethods.Add(new ASCIIOctA101());
            codingMethods.Add(new ASCIIDecimalA65());
        }

        public List<string[]> Decodify(string codeText)
        {
            List<string[]> decodedResults = new List<string[]>();
            foreach(CodingMethod codingMethod in codingMethods)
            {
                decodedResults.Add(this.GetResultListItem(codeText, codingMethod));
            }
            return decodedResults;
        }

        public List<string[]> Decodify(string codeText, CodeType type)
        {
            List<string[]> decodedResults = new List<string[]>();
            foreach (CodingMethod codingMethod in codingMethods)
            {
                if (codingMethod.TypeOfCode == type)
                {
                    decodedResults.Add(this.GetResultListItem(codeText, codingMethod));
                }
            }
            return decodedResults;
        }

        private string[] GetResultListItem(string codeText, CodingMethod codingMethod)
        {
            var resultListItem = new string[3];
            List<string> parsedCode = CodeParser.ParseIntoBitStrings(codeText, codingMethod.BitStringLength);
            resultListItem[0] = codingMethod.NameOfCode;
            resultListItem[1] = this.DecodeText(parsedCode, codingMethod);
            resultListItem[2] = String.Join(" ", parsedCode);
            return resultListItem;
        }

        private string DecodeText(List<string> bitStrings, CodingMethod method)
        {
            var decodedText = new StringBuilder();
            foreach (var bitString in bitStrings)
            {
                if (String.IsNullOrWhiteSpace(bitString))
                    decodedText.Append(" ");
                else if (method.CodeKey.TryGetValue(bitString, out string matchedLetter))
                    decodedText.Append(matchedLetter);
                else decodedText.Append("_");
            }
            return decodedText.ToString();
        }
    }
}
