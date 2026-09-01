<!-- Generated file — do not edit; regenerated with the SDK. -->

# SensorInsightsRules — operations

Accessor: `client.SensorInsightsRules` · Source: `Api/SensorInsightsRules.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SensorInsightsListRulesRequest

- **Signature**: `SensorInsightsListRulesRequest(DtoListRulesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ResourceRule>`
- **Error**: `SdkException<SensorInsightsListRulesRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoListRulesRequest` | `Models/DtoListRulesRequest.cs` |
| `ResourceRule` | `Models/ResourceRule.cs` |
| `SensorInsightsListRulesRequestError` | `Errors/SensorInsightsListRulesRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

### SensorInsightsOverwriteRuleRequest

- **Signature**: `SensorInsightsOverwriteRuleRequest(DtoOverwriteRuleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResourceRule`
- **Error**: `SdkException<SensorInsightsOverwriteRuleRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetManagementError400(out ManagementError400)` [400] · `TryGetManagementError(out ManagementError)` [401, 406, 415, 429] · `TryGetManagementError403(out ManagementError403)` [403] · `TryGetManagementError404(out ManagementError404)` [404] · `TryGetManagementError500(out ManagementError500)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DtoOverwriteRuleRequest` | `Models/DtoOverwriteRuleRequest.cs` |
| `ResourceRule` | `Models/ResourceRule.cs` |
| `SensorInsightsOverwriteRuleRequestError` | `Errors/SensorInsightsOverwriteRuleRequestError.cs` |
| `ManagementError400` | `Models/ManagementError400.cs` |
| `ManagementError` | `Models/ManagementError.cs` |
| `ManagementError403` | `Models/ManagementError403.cs` |
| `ManagementError404` | `Models/ManagementError404.cs` |
| `ManagementError500` | `Models/ManagementError500.cs` |

