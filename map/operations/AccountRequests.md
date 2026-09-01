<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountRequests — operations

Accessor: `client.AccountRequests` · Source: `Api/AccountRequests.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCurrentAsynchronousRequestStatus

- **Signature**: `GetCurrentAsynchronousRequestStatus(string aname, string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AsynchronousRequestResult`
- **Error**: `SdkException<GetCurrentAsynchronousRequestStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AsynchronousRequestResult` | `Models/AsynchronousRequestResult.cs` |
| `GetCurrentAsynchronousRequestStatusError` | `Errors/GetCurrentAsynchronousRequestStatusError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

