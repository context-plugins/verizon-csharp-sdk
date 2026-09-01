<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeviceRoleController — operations

Accessor: `client.DeviceRoleController` · Source: `Api/DeviceRoleController.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAclRulesByVendorId

- **Server group**: `ImpServer`
- **Signature**: `GetAclRulesByVendorId(string vendorId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `VendorID` ← `vendorId`
- **Returns**: `IReadOnlyList<DeviceRole>`
- **Error**: `SdkException<GetAclRulesByVendorIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetString(out string)` [400, 401, 403, 406, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeviceRole` | `Models/DeviceRole.cs` |
| `GetAclRulesByVendorIdError` | `Errors/GetAclRulesByVendorIdError.cs` |

