using System.Collections.Generic;

namespace SolverLibrary
{
    public class HexA01 : CodingMethod
    {
        public string NameOfCode { get => "Hex (A = 01)"; }
        public CodeType TypeOfCode { get => CodeType.Hex; }
        public int BitStringLength { get => 2; }
        public Dictionary<string, string> CodeKey
        {
            get => new Dictionary<string, string>
            {
                {"01", "A" },
                {"02", "B" },
                {"03", "C" },
                {"04", "D" },
                {"05", "E" },
                {"06", "F" },
                {"07", "G" },
                {"08", "H" },
                {"09", "I" },
                {"0A", "J" },
                {"0B", "K" },
                {"0C", "L" },
                {"0D", "M" },
                {"0E", "N" },
                {"0F", "O" },
                {"10", "P" },
                {"11", "Q" },
                {"12", "R" },
                {"13", "S" },
                {"14", "T" },
                {"15", "U" },
                {"16", "V" },
                {"17", "W" },
                {"18", "X" },
                {"19", "Y" },
                {"1A", "Z" }
            };
        }
    }
}
