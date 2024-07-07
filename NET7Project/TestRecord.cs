namespace NET6Project
{
    public record TestRecord
    {
        public string InitProperty { get; init; }
    }
}

//Remove this #if condition to solve the issue!
#if !NET5_0_OR_GREATER

namespace System.Runtime.CompilerServices
{
    internal sealed class IsExternalInit
    {
    }
}

#endif