using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    public class Decoder
    {
        private readonly List<CodingMethodType> codingMethods;

        public Decoder()
        {
            codingMethods = new List<CodingMethodType>();
            codingMethods.Add(new FrancisBaconCodev1());
        }

        public string Decode(UserInput code)
        {
            return "a string to display";
        }
    }
}
