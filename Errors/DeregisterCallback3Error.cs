using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class DeregisterCallback3Error : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeregisterCallback3Error(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeregisterCallback3Error AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeregisterCallback3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DeregisterCallback3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeregisterCallback3ErrorResponse : IErrorResponse<DeregisterCallback3Error>
{
    public static DeregisterCallback3ErrorResponse Instance { get; } = new();

    private DeregisterCallback3ErrorResponse()
    {
    }

    public Task<DeregisterCallback3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeregisterCallback3Error.Create(response, ct);
}
