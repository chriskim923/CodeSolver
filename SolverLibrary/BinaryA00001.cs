using System.Collections.Generic;

namespace SolverLibrary
{
    public class BinaryA00001 : CodingMethod
    {
        public string NameOfCode { get => "Binary (A = 00001)"; }
        public CodeType TypeOfCode { get => CodeType.Binary; }
        public int BitStringLength { get => 5; }
        public Dictionary<string, string> CodeKey
        {
            get => new Dictionary<string, string>
            {
                {"00001", "A" },
                {"00010", "B" },
                {"00011", "C" },
                {"00100", "D" },
                {"00101", "E" },
                {"00110", "F" },
                {"00111", "G" },
                {"01000", "H" },
                {"01001", "I" },
                {"01010", "J" },
                {"01011", "K" },
                {"01100", "L" },
                {"01101", "M" },
                {"01110", "N" },
                {"01111", "O" },
                {"10000", "P" },
                {"10001", "Q" },
                {"10010", "R" },
                {"10011", "S" },
                {"10100", "T" },
                {"10101", "U" },
                {"10110", "V" },
                {"10111", "W" },
                {"11000", "X" },
                {"11001", "Y" },
                {"11010", "Z" }
            };
        }
    }
}
