using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    interface IDecrypter
    {
        string DecryptCode(string code);
        string SolveStatus(string code);
    }
}
