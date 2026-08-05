using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class DeleteListOfLicensesToRemoveError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteListOfLicensesToRemoveError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteListOfLicensesToRemoveError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeleteListOfLicensesToRemoveError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DeleteListOfLicensesToRemoveError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteListOfLicensesToRemoveErrorResponse : IErrorResponse<DeleteListOfLicensesToRemoveError>
{
    public static DeleteListOfLicensesToRemoveErrorResponse Instance { get; } = new();

    private DeleteListOfLicensesToRemoveErrorResponse()
    {
    }

    public Task<DeleteListOfLicensesToRemoveError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteListOfLicensesToRemoveError.Create(response, ct);
}
