<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConfigurationFiles — operations

Accessor: `client.ConfigurationFiles` · Source: `Api/ConfigurationFiles.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetListOfFiles

- **Server group**: `SoftwareManagementV2`
- **Signature**: `GetListOfFiles(string acc, string distributionType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `distributionType` ← `distributionType`
- **Returns**: `RetrievesAvailableFilesResponseList`
- **Error**: `SdkException<GetListOfFilesError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrievesAvailableFilesResponseList` | `Models/RetrievesAvailableFilesResponseList.cs` |
| `GetListOfFilesError` | `Errors/GetListOfFilesError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

### UploadConfigFile

- **Server group**: `SoftwareManagementV2`
- **Signature**: `UploadConfigFile(string acc, BinaryContent? fileupload, string? fileVersion, string? make, string? model, string? localTargetPath, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`fileupload` … `localTargetPath`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `UploadConfigurationFilesResponse`
- **Error**: `SdkException<UploadConfigFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetFotaV2Result(out FotaV2Result)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadConfigurationFilesResponse` | `Models/UploadConfigurationFilesResponse.cs` |
| `UploadConfigFileError` | `Errors/UploadConfigFileError.cs` |
| `FotaV2Result` | `Models/FotaV2Result.cs` |

