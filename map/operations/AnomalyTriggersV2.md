<!-- Generated file — do not edit; regenerated with the SDK. -->

# AnomalyTriggersV2 — operations

Accessor: `client.AnomalyTriggersV2` · Source: `Api/AnomalyTriggersV2.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAnomalyDetectionTriggerV2

- **Signature**: `CreateAnomalyDetectionTriggerV2(IReadOnlyList<CreateTriggerRequestOptions> body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnomalyDetectionTrigger`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTriggerRequestOptions` | `Models/AnyOf/CreateTriggerRequestOptions.cs` |
| `AnomalyDetectionTrigger` | `Models/AnomalyDetectionTrigger.cs` |

### ListAnomalyDetectionTriggerSettingsV2

- **Signature**: `ListAnomalyDetectionTriggerSettingsV2(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnomalyTriggerResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AnomalyTriggerResult` | `Models/AnomalyTriggerResult.cs` |

### UpdateAnomalyDetectionTriggerV2

- **Signature**: `UpdateAnomalyDetectionTriggerV2(IReadOnlyList<UpdateTriggerRequestOptions> body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IntelligenceSuccessResult`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTriggerRequestOptions` | `Models/AnyOf/UpdateTriggerRequestOptions.cs` |
| `IntelligenceSuccessResult` | `Models/IntelligenceSuccessResult.cs` |

