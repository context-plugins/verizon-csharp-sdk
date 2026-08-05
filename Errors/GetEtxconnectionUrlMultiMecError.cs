using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetEtxconnectionUrlMultiMecError : ApiError
{
    private readonly Optional<EtxrespondingError> _etxrespondingErrorValue;

    private GetEtxconnectionUrlMultiMecError(Optional<EtxrespondingError> etxrespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxrespondingErrorValue = etxrespondingErrorValue;
    }

    private static GetEtxconnectionUrlMultiMecError AsEtxrespondingError(EtxrespondingError value) =>
        new(Optional<EtxrespondingError>.Some(value), default);

    private static GetEtxconnectionUrlMultiMecError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxrespondingError(out EtxrespondingError value) =>
        _etxrespondingErrorValue.TryGetValue(out value);

    internal static Task<GetEtxconnectionUrlMultiMecError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 503 => FromJson<EtxrespondingError>(response, ct).As(AsEtxrespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEtxconnectionUrlMultiMecErrorResponse : IErrorResponse<GetEtxconnectionUrlMultiMecError>
{
    public static GetEtxconnectionUrlMultiMecErrorResponse Instance { get; } = new();

    private GetEtxconnectionUrlMultiMecErrorResponse()
    {
    }

    public Task<GetEtxconnectionUrlMultiMecError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEtxconnectionUrlMultiMecError.Create(response, ct);
}
