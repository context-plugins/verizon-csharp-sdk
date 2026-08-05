using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RegisterCallback3Error : ApiError
{
    private readonly Optional<FotaV1Result> _fotaV1ResultValue;

    private RegisterCallback3Error(Optional<FotaV1Result> fotaV1ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV1ResultValue = fotaV1ResultValue;
    }

    private static RegisterCallback3Error AsFotaV1Result(FotaV1Result value) =>
        new(Optional<FotaV1Result>.Some(value), default);

    private static RegisterCallback3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV1Result(out FotaV1Result value) => _fotaV1ResultValue.TryGetValue(out value);

    internal static Task<RegisterCallback3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV1Result>(response, ct).As(AsFotaV1Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RegisterCallback3ErrorResponse : IErrorResponse<RegisterCallback3Error>
{
    public static RegisterCallback3ErrorResponse Instance { get; } = new();

    private RegisterCallback3ErrorResponse()
    {
    }

    public Task<RegisterCallback3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RegisterCallback3Error.Create(response, ct);
}
