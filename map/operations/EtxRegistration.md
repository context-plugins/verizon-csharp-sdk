<!-- Generated file — do not edit; regenerated with the SDK. -->

# EtxRegistration — operations

Accessor: `client.EtxRegistration` · Source: `Api/EtxRegistration.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEtxClientCertificate

- **Server group**: `ImpServer`
- **Signature**: `GetEtxClientCertificate(EtxClientIdLookup id, string vendorId, Guid? xTransactionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `ID` ← `id`
- **Returns**: `ClientPersistenceResponse`
- **Error**: `SdkException<GetEtxClientCertificateError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 404, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EtxClientIdLookup` | `Models/EtxClientIdLookup.cs` |
| `ClientPersistenceResponse` | `Models/ClientPersistenceResponse.cs` |
| `GetEtxClientCertificateError` | `Errors/GetEtxClientCertificateError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

### GetEtxConnectionUrl

- **Server group**: `ImpServer`
- **Signature**: `GetEtxConnectionUrl(string vendorId, Guid? xTransactionId, ConnectionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
- **Returns**: `ConnectionResponse`
- **Error**: `SdkException<GetEtxConnectionUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConnectionRequest` | `Models/ConnectionRequest.cs` |
| `ConnectionResponse` | `Models/ConnectionResponse.cs` |
| `GetEtxConnectionUrlError` | `Errors/GetEtxConnectionUrlError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

### GetEtxConnectionUrlMultiMec

- **Server group**: `ImpServer`
- **Signature**: `GetEtxConnectionUrlMultiMec(string vendorId, Guid? xTransactionId, ConnectionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
- **Returns**: `ConnectionResponseV3`
- **Error**: `SdkException<GetEtxConnectionUrlMultiMecError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConnectionRequest` | `Models/ConnectionRequest.cs` |
| `ConnectionResponseV3` | `Models/ConnectionResponseV3.cs` |
| `GetEtxConnectionUrlMultiMecError` | `Errors/GetEtxConnectionUrlMultiMecError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

### QueryEtxDevices

- **Server group**: `ImpServer`
- **Signature**: `QueryEtxDevices(Guid? xTransactionId, DevicesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<DevicesResponse>`
- **Error**: `SdkException<QueryEtxDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DevicesRequest` | `Models/DevicesRequest.cs` |
| `DevicesResponse` | `Models/DevicesResponse.cs` |
| `QueryEtxDevicesError` | `Errors/QueryEtxDevicesError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

### RegisterEtxClient

- **Server group**: `ImpServer`
- **Signature**: `RegisterEtxClient(Guid? xTransactionId, ClientRegistrationRequestV2 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
- **Returns**: `ClientRegistrationResponse`
- **Error**: `SdkException<RegisterEtxClientError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClientRegistrationRequestV2` | `Models/ClientRegistrationRequestV2.cs` |
| `ClientRegistrationResponse` | `Models/ClientRegistrationResponse.cs` |
| `RegisterEtxClientError` | `Errors/RegisterEtxClientError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

### RenewEtxClientCertificate

- **Server group**: `ImpServer`
- **Signature**: `RenewEtxClientCertificate(Guid deviceId, string vendorId, Guid? xTransactionId, object? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ClientRegistrationResponse`
- **Error**: `SdkException<RenewEtxClientCertificateError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClientRegistrationResponse` | `Models/ClientRegistrationResponse.cs` |
| `RenewEtxClientCertificateError` | `Errors/RenewEtxClientCertificateError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

### UnregisterEtxClients

- **Server group**: `ImpServer`
- **Signature**: `UnregisterEtxClients(IReadOnlyList<Guid> deviceIDs, string vendorId, Guid? xTransactionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `xTransactionId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `DeviceIDs` ← `deviceIDs`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UnregisterEtxClientsError>` — **Case A (typed)**
- **Error accessors**: `TryGetEtxRespondingError(out EtxRespondingError)` [400, 401, 403, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnregisterEtxClientsError` | `Errors/UnregisterEtxClientsError.cs` |
| `EtxRespondingError` | `Models/EtxRespondingError.cs` |

