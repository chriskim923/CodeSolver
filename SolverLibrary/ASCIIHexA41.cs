using System.Collections.Generic;

namespace SolverLibrary
{
    public class ASCIIHexA41 : CodingMethod
    {
        public string NameOfCode { get => "ASCII Hex (A = 41)"; }
        public CodeType TypeOfCode { get => CodeType.Hex; }
        public int BitStringLength { get => 2; }
        public Dictionary<string, string> CodeKey
        {
            get => new Dictionary<string, string>
            {
                {"30", "0" },
                {"31", "1" },
                {"32", "2" },
                {"33", "3" },
                {"34", "4" },
                {"35", "5" },
                {"36", "6" },
                {"37", "7" },
                {"38", "8" },
                {"39", "9" },
                {"41", "A" },
                {"42", "B" },
                {"43", "C" },
                {"44", "D" },
                {"45", "E" },
                {"46", "F" },
                {"47", "G" },
                {"48", "H" },
                {"49", "I" },
                {"4A", "J" },
                {"4B", "K" },
                {"4C", "L" },
                {"4D", "M" },
                {"4E", "N" },
                {"4F", "O" },
                {"50", "P" },
                {"51", "Q" },
                {"52", "R" },
                {"53", "S" },
                {"54", "T" },
                {"55", "U" },
                {"56", "V" },
                {"57", "W" },
                {"58", "X" },
                {"59", "Y" },
                {"5A", "Z" }
            };
        }
    }
}
