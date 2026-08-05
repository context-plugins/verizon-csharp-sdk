using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class EnableDeviceLoggingError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private EnableDeviceLoggingError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static EnableDeviceLoggingError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static EnableDeviceLoggingError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<EnableDeviceLoggingError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EnableDeviceLoggingErrorResponse : IErrorResponse<EnableDeviceLoggingError>
{
    public static EnableDeviceLoggingErrorResponse Instance { get; } = new();

    private EnableDeviceLoggingErrorResponse()
    {
    }

    public Task<EnableDeviceLoggingError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EnableDeviceLoggingError.Create(response, ct);
}
