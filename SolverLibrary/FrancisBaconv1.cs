using System.Collections.Generic;

namespace SolverLibrary
{
    public class FrancisBaconv1 : CodingMethod
    {
        public string NameOfCode { get => "Bacon's Cipher (Original)"; }
        public CodeType TypeOfCode { get => CodeType.Binary; }
        public int BitStringLength { get => 5; }
        public Dictionary<string, string> CodeKey
        {
            get => new Dictionary<string, string>
            {
                {"00000", "A" },
                {"00001", "B" },
                {"00010", "C" },
                {"00011", "D" },
                {"00100", "E" },
                {"00101", "F" },
                {"00110", "G" },
                {"00111", "H" },
                {"01000", "(I/J)" },
                {"01001", "K" },
                {"01010", "L" },
                {"01011", "M" },
                {"01100", "N" },
                {"01101", "O" },
                {"01110", "P" },
                {"01111", "Q" },
                {"10000", "R" },
                {"10001", "S" },
                {"10010", "T" },
                {"10011", "(U/V)" },
                {"10100", "W" },
                {"10101", "X" },
                {"10110", "Y" },
                {"10111", "Z" }
            };
        }
    }
}
