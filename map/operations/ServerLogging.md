<!-- Generated file — do not edit; regenerated with the SDK. -->

# ServerLogging — operations

Accessor: `client.ServerLogging` · Source: `Api/ServerLogging.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDeviceCheckInHistory

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetDeviceCheckInHistory(string account, string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<CheckInHistoryItem>`
- **Error**: `SdkException<GetDeviceCheckInHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckInHistoryItem` | `Models/CheckInHistoryItem.cs` |
| `GetDeviceCheckInHistoryError` | `Errors/GetDeviceCheckInHistoryError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

