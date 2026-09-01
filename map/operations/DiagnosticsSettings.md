<!-- Generated file — do not edit; regenerated with the SDK. -->

# DiagnosticsSettings — operations

Accessor: `client.DiagnosticsSettings` · Source: `Api/DiagnosticsSettings.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListDiagnosticsSettings

- **Server group**: `DeviceDiagnostics`
- **Signature**: `ListDiagnosticsSettings(string accountName, string devices, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `accountName` ← `accountName`, `devices` ← `devices`
- **Returns**: `IReadOnlyList<DiagnosticObservationSetting>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DiagnosticObservationSetting` | `Models/DiagnosticObservationSetting.cs` |

