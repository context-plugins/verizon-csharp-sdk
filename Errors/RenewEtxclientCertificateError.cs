using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RenewEtxclientCertificateError : ApiError
{
    private readonly Optional<EtxrespondingError> _etxrespondingErrorValue;

    private RenewEtxclientCertificateError(Optional<EtxrespondingError> etxrespondingErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _etxrespondingErrorValue = etxrespondingErrorValue;
    }

    private static RenewEtxclientCertificateError AsEtxrespondingError(EtxrespondingError value) =>
        new(Optional<EtxrespondingError>.Some(value), default);

    private static RenewEtxclientCertificateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetEtxrespondingError(out EtxrespondingError value) =>
        _etxrespondingErrorValue.TryGetValue(out value);

    internal static Task<RenewEtxclientCertificateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 503 => FromJson<EtxrespondingError>(response, ct).As(AsEtxrespondingError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RenewEtxclientCertificateErrorResponse : IErrorResponse<RenewEtxclientCertificateError>
{
    public static RenewEtxclientCertificateErrorResponse Instance { get; } = new();

    private RenewEtxclientCertificateErrorResponse()
    {
    }

    public Task<RenewEtxclientCertificateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RenewEtxclientCertificateError.Create(response, ct);
}
