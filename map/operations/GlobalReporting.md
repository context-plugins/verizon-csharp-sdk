<!-- Generated file — do not edit; regenerated with the SDK. -->

# GlobalReporting — operations

Accessor: `client.GlobalReporting` · Source: `Api/GlobalReporting.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeviceprovhistoryUsingPost

- **Signature**: `DeviceprovhistoryUsingPost(ESimProvhistoryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ESimRequestResponse`
- **Error**: `SdkException<DeviceprovhistoryUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ESimProvhistoryRequest` | `Models/ESimProvhistoryRequest.cs` |
| `ESimRequestResponse` | `Models/ESimRequestResponse.cs` |
| `DeviceprovhistoryUsingPostError` | `Errors/DeviceprovhistoryUsingPostError.cs` |
| `ESimRestErrorResponse` | `Models/ESimRestErrorResponse.cs` |

### RetrieveGlobalList

- **Signature**: `RetrieveGlobalList(ESimGlobalDeviceList body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ESimRequestResponse`
- **Error**: `SdkException<RetrieveGlobalListError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ESimGlobalDeviceList` | `Models/ESimGlobalDeviceList.cs` |
| `ESimRequestResponse` | `Models/ESimRequestResponse.cs` |
| `RetrieveGlobalListError` | `Errors/RetrieveGlobalListError.cs` |
| `ESimRestErrorResponse` | `Models/ESimRestErrorResponse.cs` |

