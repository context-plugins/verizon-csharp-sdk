using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RegisterEtxClientError : ApiError
{
    private readonly Optional<EtxRespondingError> _etxRespondingErrorValue;

    private RegisterEtxClientError(Optional<EtxRespondingError> etxRespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxRespondingErrorValue = etxRespondingErrorValue;
    }

    private static RegisterEtxClientError AsEtxRespondingError(EtxRespondingError value) =>
        new(Optional<EtxRespondingError>.Some(value), default);

    private static RegisterEtxClientError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxRespondingError(out EtxRespondingError value) =>
        _etxRespondingErrorValue.TryGetValue(out value);

    internal static Task<RegisterEtxClientError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 503 => FromJson<EtxRespondingError>(response, ct).As(AsEtxRespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RegisterEtxClientErrorResponse : IErrorResponse<RegisterEtxClientError>
{
    public static RegisterEtxClientErrorResponse Instance { get; } = new();

    private RegisterEtxClientErrorResponse()
    {
    }

    public Task<RegisterEtxClientError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RegisterEtxClientError.Create(response, ct);
}
