namespace NET6Project
{
    public record TestRecord
    {
        public string InitProperty { get; init; }
    }
}

#if !NET5_0_OR_GREATER

namespace System.Runtime.CompilerServices
{
    internal sealed class IsExternalInit
    {
    }
}

#endif