using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class QueryMapMessagesError : ApiError
{
    private readonly Optional<MdmErrorResponse> _mdmErrorResponseValue;

    private QueryMapMessagesError(Optional<MdmErrorResponse> mdmErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _mdmErrorResponseValue = mdmErrorResponseValue;
    }

    private static QueryMapMessagesError AsMdmErrorResponse(MdmErrorResponse value) =>
        new(Optional<MdmErrorResponse>.Some(value), default);

    private static QueryMapMessagesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetMdmErrorResponse(out MdmErrorResponse value) =>
        _mdmErrorResponseValue.TryGetValue(out value);

    internal static Task<QueryMapMessagesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 405 or 429 or 503 => FromJson<MdmErrorResponse>(response, ct).As(AsMdmErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMapMessagesErrorResponse : IErrorResponse<QueryMapMessagesError>
{
    public static QueryMapMessagesErrorResponse Instance { get; } = new();

    private QueryMapMessagesErrorResponse()
    {
    }

    public Task<QueryMapMessagesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMapMessagesError.Create(response, ct);
}
