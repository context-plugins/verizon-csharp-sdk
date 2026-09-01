<!-- Generated file — do not edit; regenerated with the SDK. -->

# Accounts — operations

Accessor: `client.Accounts` · Source: `Api/Accounts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountInformation

- **Signature**: `GetAccountInformation(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Account`
- **Error**: `SdkException<GetAccountInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Account` | `Models/Account.cs` |
| `GetAccountInformationError` | `Errors/GetAccountInformationError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListAccountLeads

- **Signature**: `ListAccountLeads(string aname, long? next, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `next` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `next` ← `next`
- **Returns**: `AccountLeadsResult`
- **Error**: `SdkException<ListAccountLeadsError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountLeadsResult` | `Models/AccountLeadsResult.cs` |
| `ListAccountLeadsError` | `Errors/ListAccountLeadsError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

### ListAccountStatesAndServices

- **Signature**: `ListAccountStatesAndServices(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountStatesAndServices`
- **Error**: `SdkException<ListAccountStatesAndServicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetConnectivityManagementResult(out ConnectivityManagementResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountStatesAndServices` | `Models/AccountStatesAndServices.cs` |
| `ListAccountStatesAndServicesError` | `Errors/ListAccountStatesAndServicesError.cs` |
| `ConnectivityManagementResult` | `Models/ConnectivityManagementResult.cs` |

