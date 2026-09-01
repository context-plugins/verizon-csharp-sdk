<!-- Generated file — do not edit; regenerated with the SDK. -->

# MapMessageController — operations

Accessor: `client.MapMessageController` · Source: `Api/MapMessageController.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMapMessage

- **Server group**: `ImpServer`
- **Signature**: `DeleteMapMessage(string regionId, string i10Nid, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteMapMessageError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 404, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMapMessageError` | `Errors/DeleteMapMessageError.cs` |
| `MdmErrorResponse` | `Models/MdmErrorResponse.cs` |

### DownloadMapMessages

- **Server group**: `ImpServer`
- **Signature**: `DownloadMapMessages(GeofencePolygon geofence, string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `Geofence` ← `geofence`
- **Returns**: `string`
- **Error**: `SdkException<DownloadMapMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 404, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeofencePolygon` | `Models/GeofencePolygon.cs` |
| `DownloadMapMessagesError` | `Errors/DownloadMapMessagesError.cs` |
| `MdmErrorResponse` | `Models/MdmErrorResponse.cs` |

### IngestMapMessages

- **Server group**: `ImpServer`
- **Signature**: `IngestMapMessages(string vendorId, EtxMessageStandardEnum mapDataMessageStandard, EtxMapDataIngestRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `string`
- **Error**: `SdkException<IngestMapMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 405, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EtxMessageStandardEnum` | `Models/Enums/EtxMessageStandardEnum.cs` |
| `EtxMapDataIngestRequest` | `Models/EtxMapDataIngestRequest.cs` |
| `IngestMapMessagesError` | `Errors/IngestMapMessagesError.cs` |
| `MdmErrorResponse` | `Models/MdmErrorResponse.cs` |

### QueryMapMessages

- **Server group**: `ImpServer`
- **Signature**: `QueryMapMessages(string vendorId, MapDataQueryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<object>`
- **Error**: `SdkException<QueryMapMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetMdmErrorResponse(out MdmErrorResponse)` [400, 401, 403, 405, 429, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MapDataQueryRequest` | `Models/AnyOf/MapDataQueryRequest.cs` |
| `QueryMapMessagesError` | `Errors/QueryMapMessagesError.cs` |
| `MdmErrorResponse` | `Models/MdmErrorResponse.cs` |

