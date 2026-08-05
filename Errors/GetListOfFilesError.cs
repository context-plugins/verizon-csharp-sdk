using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetListOfFilesError : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private GetListOfFilesError(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static GetListOfFilesError AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static GetListOfFilesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<GetListOfFilesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetListOfFilesErrorResponse : IErrorResponse<GetListOfFilesError>
{
    public static GetListOfFilesErrorResponse Instance { get; } = new();

    private GetListOfFilesErrorResponse()
    {
    }

    public Task<GetListOfFilesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetListOfFilesError.Create(response, ct);
}
