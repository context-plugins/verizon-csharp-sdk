using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class UploadConfigFileError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private UploadConfigFileError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static UploadConfigFileError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static UploadConfigFileError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<UploadConfigFileError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UploadConfigFileErrorResponse : IErrorResponse<UploadConfigFileError>
{
    public static UploadConfigFileErrorResponse Instance { get; } = new();

    private UploadConfigFileErrorResponse()
    {
    }

    public Task<UploadConfigFileError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UploadConfigFileError.Create(response, ct);
}
