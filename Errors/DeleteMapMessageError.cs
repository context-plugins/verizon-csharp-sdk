using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class DeleteMapMessageError : ApiError
{
    private readonly Optional<MdmErrorResponse> _mdmErrorResponseValue;

    private DeleteMapMessageError(Optional<MdmErrorResponse> mdmErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _mdmErrorResponseValue = mdmErrorResponseValue;
    }

    private static DeleteMapMessageError AsMdmErrorResponse(MdmErrorResponse value) =>
        new(Optional<MdmErrorResponse>.Some(value), default);

    private static DeleteMapMessageError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetMdmErrorResponse(out MdmErrorResponse value) =>
        _mdmErrorResponseValue.TryGetValue(out value);

    internal static Task<DeleteMapMessageError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 429 or 503 => FromJson<MdmErrorResponse>(response, ct).As(AsMdmErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteMapMessageErrorResponse : IErrorResponse<DeleteMapMessageError>
{
    public static DeleteMapMessageErrorResponse Instance { get; } = new();

    private DeleteMapMessageErrorResponse()
    {
    }

    public Task<DeleteMapMessageError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteMapMessageError.Create(response, ct);
}
