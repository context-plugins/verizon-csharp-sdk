<!-- Generated file — do not edit; regenerated with the SDK. -->

# AnomalySettings — operations

Accessor: `client.AnomalySettings` · Source: `Api/AnomalySettings.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateAnomalyDetection

- **Signature**: `ActivateAnomalyDetection(AnomalyDetectionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IntelligenceSuccessResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AnomalyDetectionRequest` | `Models/AnomalyDetectionRequest.cs` |
| `IntelligenceSuccessResult` | `Models/IntelligenceSuccessResult.cs` |

### ListAnomalyDetectionSettings

- **Signature**: `ListAnomalyDetectionSettings(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnomalyDetectionSettings`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AnomalyDetectionSettings` | `Models/AnomalyDetectionSettings.cs` |

### ResetAnomalyDetectionParameters

- **Signature**: `ResetAnomalyDetectionParameters(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IntelligenceSuccessResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IntelligenceSuccessResult` | `Models/IntelligenceSuccessResult.cs` |

