using System.Collections.Generic;

namespace SolverLibrary
{
    public enum CodeType
    {
        Binary,
        Ternary,
        Hex,
        Octal,
        Decimal
    };

    public interface CodingMethod
    {
        string NameOfCode { get; }
        CodeType TypeOfCode { get; }
        int BitStringLength { get; }
        Dictionary<string, string> CodeKey { get; }
    }
}
