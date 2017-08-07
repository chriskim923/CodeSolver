using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    interface IDecoder
    {
        string GetDecodedResults(UserInput text);
    }
}
