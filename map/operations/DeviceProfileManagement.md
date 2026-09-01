<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceProfileManagement — operations

Accessor: `client.DeviceProfileManagement` · Source: `Api/DeviceProfileManagement.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateDeviceThroughProfile

- **Signature**: `ActivateDeviceThroughProfile(ActivateDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<ActivateDeviceThroughProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateDeviceProfileRequest` | `Models/ActivateDeviceProfileRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `ActivateDeviceThroughProfileError` | `Errors/ActivateDeviceThroughProfileError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### ProfileToActivateDevice

- **Signature**: `ProfileToActivateDevice(ProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<ProfileToActivateDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProfileRequest` | `Models/ProfileRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `ProfileToActivateDeviceError` | `Errors/ProfileToActivateDeviceError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### ProfileToDeactivateDevice

- **Signature**: `ProfileToDeactivateDevice(DeactivateDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<ProfileToDeactivateDeviceError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeactivateDeviceProfileRequest` | `Models/DeactivateDeviceProfileRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `ProfileToDeactivateDeviceError` | `Errors/ProfileToDeactivateDeviceError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

### ProfileToSetFallbackAttribute

- **Signature**: `ProfileToSetFallbackAttribute(SetFallbackAttributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RequestResponse`
- **Error**: `SdkException<ProfileToSetFallbackAttributeError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponse(out RestErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetFallbackAttributeRequest` | `Models/SetFallbackAttributeRequest.cs` |
| `RequestResponse` | `Models/RequestResponse.cs` |
| `ProfileToSetFallbackAttributeError` | `Errors/ProfileToSetFallbackAttributeError.cs` |
| `RestErrorResponse` | `Models/RestErrorResponse.cs` |

