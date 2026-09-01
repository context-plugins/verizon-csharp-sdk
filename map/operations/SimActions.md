<!-- Generated file — do not edit; regenerated with the SDK. -->

# SimActions — operations

Accessor: `client.SimActions` · Source: `Api/SimActions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Newactivatecode

- **Signature**: `Newactivatecode(ESimProfileRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ESimRequestResponse`
- **Error**: `SdkException<NewactivatecodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ESimProfileRequest2` | `Models/ESimProfileRequest2.cs` |
| `ESimRequestResponse` | `Models/ESimRequestResponse.cs` |
| `NewactivatecodeError` | `Errors/NewactivatecodeError.cs` |
| `ESimRestErrorResponse` | `Models/ESimRestErrorResponse.cs` |

### SetactivateUsingPost

- **Signature**: `SetactivateUsingPost(ESimProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ESimRequestResponse`
- **Error**: `SdkException<SetactivateUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ESimProfileRequest` | `Models/ESimProfileRequest.cs` |
| `ESimRequestResponse` | `Models/ESimRequestResponse.cs` |
| `SetactivateUsingPostError` | `Errors/SetactivateUsingPostError.cs` |
| `ESimRestErrorResponse` | `Models/ESimRestErrorResponse.cs` |

### SetdeactivateUsingPost

- **Signature**: `SetdeactivateUsingPost(ProfileRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ESimRequestResponse`
- **Error**: `SdkException<SetdeactivateUsingPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetESimRestErrorResponse(out ESimRestErrorResponse)` [400, 401, 403, 404, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileRequest2` | `Models/ProfileRequest2.cs` |
| `ESimRequestResponse` | `Models/ESimRequestResponse.cs` |
| `SetdeactivateUsingPostError` | `Errors/SetdeactivateUsingPostError.cs` |
| `ESimRestErrorResponse` | `Models/ESimRestErrorResponse.cs` |

