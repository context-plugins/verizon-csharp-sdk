<!-- Generated file — do not edit; regenerated with the SDK. -->

# RetrieveTheTriggers — operations

Accessor: `client.RetrieveTheTriggers` · Source: `Api/RetrieveTheTriggers.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAllAvailableTriggers

- **Signature**: `GetAllAvailableTriggers(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TriggerValueResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TriggerValueResponse` | `Models/TriggerValueResponse.cs` |

### GetAllTriggersByAccountName

- **Signature**: `GetAllTriggersByAccountName(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TriggerValueResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TriggerValueResponse` | `Models/TriggerValueResponse.cs` |

### GetAllTriggersByTriggerCategory

- **Signature**: `GetAllTriggersByTriggerCategory(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TriggerValueResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TriggerValueResponse2` | `Models/TriggerValueResponse2.cs` |

### GetTriggersById

- **Signature**: `GetTriggersById(string triggerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TriggerValueResponse2`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TriggerValueResponse2` | `Models/TriggerValueResponse2.cs` |

