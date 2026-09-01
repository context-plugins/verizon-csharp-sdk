using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class IngestMapMessagesError : ApiError
{
    private readonly Optional<MdmErrorResponse> _mdmErrorResponseValue;

    private IngestMapMessagesError(Optional<MdmErrorResponse> mdmErrorResponseValue, Optional<RawError> fallback) : base(fallback)
    {
        _mdmErrorResponseValue = mdmErrorResponseValue;
    }

    private static IngestMapMessagesError AsMdmErrorResponse(MdmErrorResponse value) =>
        new(Optional<MdmErrorResponse>.Some(value), default);

    private static IngestMapMessagesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetMdmErrorResponse(out MdmErrorResponse value) =>
        _mdmErrorResponseValue.TryGetValue(out value);

    internal static Task<IngestMapMessagesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 405 or 429 or 503 => FromJson<MdmErrorResponse>(response, ct).As(AsMdmErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class IngestMapMessagesErrorResponse : IErrorResponse<IngestMapMessagesError>
{
    public static IngestMapMessagesErrorResponse Instance { get; } = new();

    private IngestMapMessagesErrorResponse()
    {
    }

    public Task<IngestMapMessagesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        IngestMapMessagesError.Create(response, ct);
}
