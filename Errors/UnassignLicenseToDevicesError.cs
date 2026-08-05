using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UnassignLicenseToDevicesError : ApiError
{
    private readonly Optional<SecurityResult> _securityResultValue;

    private UnassignLicenseToDevicesError(Optional<SecurityResult> securityResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _securityResultValue = securityResultValue;
    }

    private static UnassignLicenseToDevicesError AsSecurityResult(SecurityResult value) =>
        new(Optional<SecurityResult>.Some(value), default);

    private static UnassignLicenseToDevicesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetSecurityResult(out SecurityResult value) => _securityResultValue.TryGetValue(out value);

    internal static Task<UnassignLicenseToDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 406 or 429 => FromJson<SecurityResult>(response, ct).As(AsSecurityResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UnassignLicenseToDevicesErrorResponse : IErrorResponse<UnassignLicenseToDevicesError>
{
    public static UnassignLicenseToDevicesErrorResponse Instance { get; } = new();

    private UnassignLicenseToDevicesErrorResponse()
    {
    }

    public Task<UnassignLicenseToDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UnassignLicenseToDevicesError.Create(response, ct);
}
