<!-- Generated file — do not edit; regenerated with the SDK. -->

# Pwn — operations

Accessor: `client.Pwn` · Source: `Api/Pwn.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangePwnDeviceIPaddress

- **Signature**: `ChangePwnDeviceIPaddress(ChangePwnDeviceIPaddressRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangePwnDeviceIpAddressResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceIPaddressRequest` | `Models/ChangePwnDeviceIPaddressRequest.cs` |
| `ChangePwnDeviceIpAddressResponse` | `Models/ChangePwnDeviceIpAddressResponse.cs` |

### ChangePwnDeviceProfile

- **Signature**: `ChangePwnDeviceProfile(ChangePwnDeviceProfileRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangePwnDeviceProfileResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceProfileRequest` | `Models/ChangePwnDeviceProfileRequest.cs` |
| `ChangePwnDeviceProfileResponse` | `Models/ChangePwnDeviceProfileResponse.cs` |

### ChangePwnDeviceStateActivate

- **Signature**: `ChangePwnDeviceStateActivate(ChangePwnDeviceStateActivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangePwnDeviceStateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceStateActivateRequest` | `Models/ChangePwnDeviceStateActivateRequest.cs` |
| `ChangePwnDeviceStateResponse` | `Models/ChangePwnDeviceStateResponse.cs` |

### ChangePwnDeviceStateDeactivate

- **Signature**: `ChangePwnDeviceStateDeactivate(ChangePwnDeviceStateDeactivateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangePwnDeviceStateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangePwnDeviceStateDeactivateRequest` | `Models/ChangePwnDeviceStateDeactivateRequest.cs` |
| `ChangePwnDeviceStateResponse` | `Models/ChangePwnDeviceStateResponse.cs` |

### GetProfileList

- **Signature**: `GetProfileList(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PwnProfileList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PwnProfileList` | `Models/PwnProfileList.cs` |

### GetPwnPerformanceConsent

- **Signature**: `GetPwnPerformanceConsent(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetPwnPerformanceConsentResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetPwnPerformanceConsentResponse` | `Models/GetPwnPerformanceConsentResponse.cs` |

### KpiList

- **Signature**: `KpiList(string aname, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `KpiInfoList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `KpiInfoList` | `Models/KpiInfoList.cs` |

