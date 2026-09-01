using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;

namespace Verizon.Errors;

public sealed class GetAclRulesByVendorIdError : ApiError
{
    private readonly Optional<string> _stringValue;

    private GetAclRulesByVendorIdError(Optional<string> stringValue, Optional<RawError> fallback) : base(fallback)
    {
        _stringValue = stringValue;
    }

    private static GetAclRulesByVendorIdError AsString(string value) =>
        new(Optional<string>.Some(value), default);

    private static GetAclRulesByVendorIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    internal static Task<GetAclRulesByVendorIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 406 or 429 => FromScalar(response, ct, s => s).As(AsString),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAclRulesByVendorIdErrorResponse : IErrorResponse<GetAclRulesByVendorIdError>
{
    public static GetAclRulesByVendorIdErrorResponse Instance { get; } = new();

    private GetAclRulesByVendorIdErrorResponse()
    {
    }

    public Task<GetAclRulesByVendorIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAclRulesByVendorIdError.Create(response, ct);
}
