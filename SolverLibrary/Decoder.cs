using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    public class Decoder : IDecoder
    {
        private readonly List<ICodingMethod> codingMethods;

        public Decoder()
        {
            codingMethods = new List<ICodingMethod>();

        }

        public string GetDecodedResults(UserInput code)
        {
            return "a string to display";
        }
    }
}
