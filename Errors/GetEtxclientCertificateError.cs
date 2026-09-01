using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetEtxClientCertificateError : ApiError
{
    private readonly Optional<EtxRespondingError> _etxRespondingErrorValue;

    private GetEtxClientCertificateError(Optional<EtxRespondingError> etxRespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxRespondingErrorValue = etxRespondingErrorValue;
    }

    private static GetEtxClientCertificateError AsEtxRespondingError(EtxRespondingError value) =>
        new(Optional<EtxRespondingError>.Some(value), default);

    private static GetEtxClientCertificateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxRespondingError(out EtxRespondingError value) =>
        _etxRespondingErrorValue.TryGetValue(out value);

    internal static Task<GetEtxClientCertificateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 429 or 500 => FromJson<EtxRespondingError>(response, ct).As(AsEtxRespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEtxClientCertificateErrorResponse : IErrorResponse<GetEtxClientCertificateError>
{
    public static GetEtxClientCertificateErrorResponse Instance { get; } = new();

    private GetEtxClientCertificateErrorResponse()
    {
    }

    public Task<GetEtxClientCertificateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEtxClientCertificateError.Create(response, ct);
}
