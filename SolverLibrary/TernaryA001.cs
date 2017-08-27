using System.Collections.Generic;

namespace SolverLibrary
{
    public class TernaryA001 : CodingMethod
    {
        public string NameOfCode { get => "Ternary (A = 001)"; }
        public CodeType TypeOfCode { get => CodeType.Ternary; }
        public int BitStringLength { get => 3; }
        public Dictionary<string, string> CodeKey
        {
            get => new Dictionary<string, string>
            {
                {"001", "A" },
                {"002", "B" },
                {"010", "C" },
                {"011", "D" },
                {"012", "E" },
                {"020", "F" },
                {"021", "G" },
                {"022", "H" },
                {"100", "I" },
                {"101", "J" },
                {"102", "K" },
                {"110", "L" },
                {"111", "M" },
                {"112", "N" },
                {"120", "O" },
                {"121", "P" },
                {"122", "Q" },
                {"200", "R" },
                {"201", "S" },
                {"202", "T" },
                {"210", "U" },
                {"211", "V" },
                {"212", "W" },
                {"220", "X" },
                {"221", "Y" },
                {"222", "Z" }
            };
        }
    }
}
