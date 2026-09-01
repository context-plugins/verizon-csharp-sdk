<!-- Generated file — do not edit; regenerated with the SDK. -->

# ServicePlans — operations

Accessor: `client.ServicePlans` · Source: `Api/ServicePlans.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListAccountServicePlans

- **Signature**: `ListAccountServicePlans(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ServicePlan>`
- **Error**: `SdkException<ListAccountServicePlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServicePlan` | `Models/ServicePlan.cs` |
| `ListAccountServicePlansError` | `Errors/ListAccountServicePlansError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

