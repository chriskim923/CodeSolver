using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    public class InputCache
    {
        public List<UserInput> Inputs { get; set; }

        public InputCache()
        {
            this.Inputs = new List<UserInput>();
        }
    }
}
