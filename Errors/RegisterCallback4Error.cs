using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class RegisterCallback4Error : ApiError
{
    private readonly Optional<FotaV2Result> _fotaV2ResultValue;

    private RegisterCallback4Error(Optional<FotaV2Result> fotaV2ResultValue, Optional<RawError> fallback) : base(fallback)
    {
        _fotaV2ResultValue = fotaV2ResultValue;
    }

    private static RegisterCallback4Error AsFotaV2Result(FotaV2Result value) =>
        new(Optional<FotaV2Result>.Some(value), default);

    private static RegisterCallback4Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetFotaV2Result(out FotaV2Result value) => _fotaV2ResultValue.TryGetValue(out value);

    internal static Task<RegisterCallback4Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<FotaV2Result>(response, ct).As(AsFotaV2Result),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RegisterCallback4ErrorResponse : IErrorResponse<RegisterCallback4Error>
{
    public static RegisterCallback4ErrorResponse Instance { get; } = new();

    private RegisterCallback4ErrorResponse()
    {
    }

    public Task<RegisterCallback4Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RegisterCallback4Error.Create(response, ct);
}
