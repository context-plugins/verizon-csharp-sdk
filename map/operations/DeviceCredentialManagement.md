<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceCredentialManagement — operations

Accessor: `client.DeviceCredentialManagement` · Source: `Api/DeviceCredentialManagement.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DropCredentials

- **Signature**: `DropCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DropResponse`
- **Error**: `SdkException<DropCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CredentialsRequest` | `Models/CredentialsRequest.cs` |
| `DropResponse` | `Models/DropResponse.cs` |
| `DropCredentialsError` | `Errors/DropCredentialsError.cs` |
| `ErrorResponseModel` | `Models/ErrorResponseModel.cs` |

### GenerateCredentials

- **Signature**: `GenerateCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenerateResponse`
- **Error**: `SdkException<GenerateCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CredentialsRequest` | `Models/CredentialsRequest.cs` |
| `GenerateResponse` | `Models/GenerateResponse.cs` |
| `GenerateCredentialsError` | `Errors/GenerateCredentialsError.cs` |
| `ErrorResponseModel` | `Models/ErrorResponseModel.cs` |

### ResetCredentials

- **Signature**: `ResetCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GenerateResponse`
- **Error**: `SdkException<ResetCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CredentialsRequest` | `Models/CredentialsRequest.cs` |
| `GenerateResponse` | `Models/GenerateResponse.cs` |
| `ResetCredentialsError` | `Errors/ResetCredentialsError.cs` |
| `ErrorResponseModel` | `Models/ErrorResponseModel.cs` |

### RetrieveCredentials

- **Signature**: `RetrieveCredentials(CredentialsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveResponse`
- **Error**: `SdkException<RetrieveCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [400] · `TryGetNoContent(out RawError)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CredentialsRequest` | `Models/CredentialsRequest.cs` |
| `RetrieveResponse` | `Models/RetrieveResponse.cs` |
| `RetrieveCredentialsError` | `Errors/RetrieveCredentialsError.cs` |
| `ErrorResponseModel` | `Models/ErrorResponseModel.cs` |

