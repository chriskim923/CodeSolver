using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverLibrary
{
    public class UserInput
    {
        public string Code { get; set; }

        public string Display
        {
            get
            {
                return Code;
            }
        }
    }
}
