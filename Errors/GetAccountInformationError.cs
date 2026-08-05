using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Core.ErrorResponse;
using Verizon.Core.Models;
using Verizon.Models;

namespace Verizon.Errors;

public sealed class GetAccountInformationError : ApiError
{
    private readonly Optional<ConnectivityManagementResult> _connectivityManagementResultValue;

    private GetAccountInformationError(Optional<ConnectivityManagementResult> connectivityManagementResultValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _connectivityManagementResultValue = connectivityManagementResultValue;
    }

    private static GetAccountInformationError AsConnectivityManagementResult(ConnectivityManagementResult value) =>
        new(Optional<ConnectivityManagementResult>.Some(value), default);

    private static GetAccountInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetConnectivityManagementResult(out ConnectivityManagementResult value) =>
        _connectivityManagementResultValue.TryGetValue(out value);

    internal static Task<GetAccountInformationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ConnectivityManagementResult>(response, ct).As(AsConnectivityManagementResult),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountInformationErrorResponse : IErrorResponse<GetAccountInformationError>
{
    public static GetAccountInformationErrorResponse Instance { get; } = new();

    private GetAccountInformationErrorResponse()
    {
    }

    public Task<GetAccountInformationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountInformationError.Create(response, ct);
}
