using System.Collections.Generic;

namespace SolverLibrary
{
    public class FrancisBaconv2 : CodingMethod
    {
        public string NameOfCode { get => "Bacon's Cipher (Unique Key)"; }
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
                {"01000", "I" },
                {"01001", "J" },
                {"01010", "K" },
                {"01011", "L" },
                {"01100", "M" },
                {"01101", "N" },
                {"01110", "O" },
                {"01111", "P" },
                {"10000", "Q" },
                {"10001", "R" },
                {"10010", "S" },
                {"10011", "T" },
                {"10100", "U" },
                {"10101", "V" },
                {"10110", "W" },
                {"10111", "X" },
                {"11000", "Y" },
                {"11001", "Z" }
            };
        }
    }
}
