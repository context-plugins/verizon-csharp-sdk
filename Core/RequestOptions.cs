using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Verizon.Core.Hooks;

namespace Verizon.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
