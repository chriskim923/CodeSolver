using System.Collections.Generic;

namespace SolverLibrary
{
    public class ASCIIOctA101 : CodingMethod
    {
        public string NameOfCode { get => "ASCII Octal (A = 101)"; }
        public CodeType TypeOfCode { get => CodeType.Octal; }
        public int BitStringLength { get => 3; }
        public Dictionary<string, string> CodeKey
        {
            get => new Dictionary<string, string>
            {
                {"060", "0" },
                {"061", "1" },
                {"062", "2" },
                {"063", "3" },
                {"064", "4" },
                {"065", "5" },
                {"066", "6" },
                {"067", "7" },
                {"070", "8" },
                {"071", "9" },
                {"101", "A" },
                {"102", "B" },
                {"103", "C" },
                {"104", "D" },
                {"105", "E" },
                {"106", "F" },
                {"107", "G" },
                {"110", "H" },
                {"111", "I" },
                {"112", "J" },
                {"113", "K" },
                {"114", "L" },
                {"115", "M" },
                {"116", "N" },
                {"117", "O" },
                {"120", "P" },
                {"121", "Q" },
                {"122", "R" },
                {"123", "S" },
                {"124", "T" },
                {"125", "U" },
                {"126", "V" },
                {"127", "W" },
                {"130", "X" },
                {"131", "Y" },
                {"132", "Z" }
            };
        }
    }
}
