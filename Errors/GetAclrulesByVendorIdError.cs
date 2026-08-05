using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class GetAclrulesByVendorIdError : ApiError
{
    private readonly Optional<string> _stringValue;

    private GetAclrulesByVendorIdError(Optional<string> stringValue, Optional<RawError> fallback) : base(fallback)
    {
        _stringValue = stringValue;
    }

    private static GetAclrulesByVendorIdError AsString(string value) =>
        new(Optional<string>.Some(value), default);

    private static GetAclrulesByVendorIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    internal static Task<GetAclrulesByVendorIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 406 or 429 => FromScalar(response, ct, s => s).As(AsString),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAclrulesByVendorIdErrorResponse : IErrorResponse<GetAclrulesByVendorIdError>
{
    public static GetAclrulesByVendorIdErrorResponse Instance { get; } = new();

    private GetAclrulesByVendorIdErrorResponse()
    {
    }

    public Task<GetAclrulesByVendorIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAclrulesByVendorIdError.Create(response, ct);
}
