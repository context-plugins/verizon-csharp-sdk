using Microsoft.Extensions.Logging;

namespace Verizon.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
