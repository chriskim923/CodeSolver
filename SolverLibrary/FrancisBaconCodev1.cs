using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    class FrancisBaconCodev1 : ICodingMethod
    {
        private Dictionary<string, string> codeKey = new Dictionary<string, string>
        {
            {"00000", "A" },
            {"00001", "B" },
            {"00010", "C" },
            {"00011", "D" },
            {"00100", "E" },
            {"00101", "F" },
            {"00110", "G" },
            {"00111", "H" },
            {"01000", "I/J" },
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
            {"10011", "U/V" },
            {"10100", "W" },
            {"10101", "X" },
            {"10110", "Y" },
            {"10111", "Z" }
        };

        public string DecodeText(UserInput code)
        {
            return "a decoded string";
        }

        public string EncodeText(UserInput text)
        {
            return "an encoded string";
        }

    }
}
