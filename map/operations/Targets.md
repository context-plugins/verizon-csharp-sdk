<!-- Generated file — do not edit; regenerated with the SDK. -->

# Targets — operations

Accessor: `client.Targets` · Source: `Api/Targets.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAzureCentralIoTApplication

- **Server group**: `CloudConnector`
- **Signature**: `CreateAzureCentralIoTApplication(string billingaccountId, CreateIoTApplicationRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateIoTApplicationResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateIoTApplicationRequest` | `Models/CreateIoTApplicationRequest.cs` |
| `CreateIoTApplicationResponse` | `Models/CreateIoTApplicationResponse.cs` |

### CreateTarget

- **Server group**: `CloudConnector`
- **Signature**: `CreateTarget(CreateTargetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Target`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTargetRequest` | `Models/CreateTargetRequest.cs` |
| `Target` | `Models/Target.cs` |

### DeleteTarget

- **Server group**: `CloudConnector`
- **Signature**: `DeleteTarget(DeleteTargetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteTargetRequest` | `Models/DeleteTargetRequest.cs` |

### GenerateTargetExternalId

- **Server group**: `CloudConnector`
- **Signature**: `GenerateTargetExternalId(GenerateExternalIdRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenerateExternalIdResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GenerateExternalIdRequest` | `Models/GenerateExternalIdRequest.cs` |
| `GenerateExternalIdResult` | `Models/GenerateExternalIdResult.cs` |

### QueryTarget

- **Server group**: `CloudConnector`
- **Signature**: `QueryTarget(QueryTargetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Target>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QueryTargetRequest` | `Models/QueryTargetRequest.cs` |
| `Target` | `Models/Target.cs` |

