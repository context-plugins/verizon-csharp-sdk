<!-- Generated file — do not edit; regenerated with the SDK. -->

# Billing — operations

Accessor: `client.Billing` · Source: `Api/Billing.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddAccount

- **Server group**: `SubscriptionServer`
- **Signature**: `AddAccount(ManagedAccountsAddRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ManagedAccountsAddResponse`
- **Error**: `SdkException<AddAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedAccountsAddRequest` | `Models/ManagedAccountsAddRequest.cs` |
| `ManagedAccountsAddResponse` | `Models/ManagedAccountsAddResponse.cs` |
| `AddAccountError` | `Errors/AddAccountError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### CancelManagedAccountAction

- **Server group**: `SubscriptionServer`
- **Signature**: `CancelManagedAccountAction(ManagedAccountCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ManagedAccountCancelResponse`
- **Error**: `SdkException<CancelManagedAccountActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedAccountCancelRequest` | `Models/ManagedAccountCancelRequest.cs` |
| `ManagedAccountCancelResponse` | `Models/ManagedAccountCancelResponse.cs` |
| `CancelManagedAccountActionError` | `Errors/CancelManagedAccountActionError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### ListManagedAccount

- **Server group**: `SubscriptionServer`
- **Signature**: `ListManagedAccount(string accountName, string serviceName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ManagedAccountsGetAllResponse`
- **Error**: `SdkException<ListManagedAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedAccountsGetAllResponse` | `Models/ManagedAccountsGetAllResponse.cs` |
| `ListManagedAccountError` | `Errors/ListManagedAccountError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

### ManagedAccountAction

- **Server group**: `SubscriptionServer`
- **Signature**: `ManagedAccountAction(ManagedAccountsProvisionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ManagedAccountsProvisionResponse`
- **Error**: `SdkException<ManagedAccountActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeviceLocationResult(out DeviceLocationResult)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ManagedAccountsProvisionRequest` | `Models/ManagedAccountsProvisionRequest.cs` |
| `ManagedAccountsProvisionResponse` | `Models/ManagedAccountsProvisionResponse.cs` |
| `ManagedAccountActionError` | `Errors/ManagedAccountActionError.cs` |
| `DeviceLocationResult` | `Models/DeviceLocationResult.cs` |

