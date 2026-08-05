using System;

namespace Verizon.Core.Exceptions;

public sealed class SdkException<TError> : Exception
{
    public required TError Error { get; init; }
}