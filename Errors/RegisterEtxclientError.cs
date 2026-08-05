using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RegisterEtxclientError : ApiError
{
    private readonly Optional<EtxrespondingError> _etxrespondingErrorValue;

    private RegisterEtxclientError(Optional<EtxrespondingError> etxrespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxrespondingErrorValue = etxrespondingErrorValue;
    }

    private static RegisterEtxclientError AsEtxrespondingError(EtxrespondingError value) =>
        new(Optional<EtxrespondingError>.Some(value), default);

    private static RegisterEtxclientError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxrespondingError(out EtxrespondingError value) =>
        _etxrespondingErrorValue.TryGetValue(out value);

    internal static Task<RegisterEtxclientError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 503 => FromJson<EtxrespondingError>(response, ct).As(AsEtxrespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RegisterEtxclientErrorResponse : IErrorResponse<RegisterEtxclientError>
{
    public static RegisterEtxclientErrorResponse Instance { get; } = new();

    private RegisterEtxclientErrorResponse()
    {
    }

    public Task<RegisterEtxclientError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RegisterEtxclientError.Create(response, ct);
}
