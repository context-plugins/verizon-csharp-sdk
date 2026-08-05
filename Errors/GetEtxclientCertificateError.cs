using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetEtxclientCertificateError : ApiError
{
    private readonly Optional<EtxrespondingError> _etxrespondingErrorValue;

    private GetEtxclientCertificateError(Optional<EtxrespondingError> etxrespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxrespondingErrorValue = etxrespondingErrorValue;
    }

    private static GetEtxclientCertificateError AsEtxrespondingError(EtxrespondingError value) =>
        new(Optional<EtxrespondingError>.Some(value), default);

    private static GetEtxclientCertificateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxrespondingError(out EtxrespondingError value) =>
        _etxrespondingErrorValue.TryGetValue(out value);

    internal static Task<GetEtxclientCertificateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 429 or 500 => FromJson<EtxrespondingError>(response, ct).As(AsEtxrespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEtxclientCertificateErrorResponse : IErrorResponse<GetEtxclientCertificateError>
{
    public static GetEtxclientCertificateErrorResponse Instance { get; } = new();

    private GetEtxclientCertificateErrorResponse()
    {
    }

    public Task<GetEtxclientCertificateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEtxclientCertificateError.Create(response, ct);
}
