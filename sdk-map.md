<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Verizon (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Verizon |
| Root namespace | `Verizon` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `v1.0` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file and `Verizon.csproj` — never to the page that carries them. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new VerizonClientOptions
    {
        VzM2MToken = "YOUR_API_KEY",
        SessionToken = "YOUR_API_KEY",
        ThingspaceOauth = new OAuth2ClientCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            ClientSecret = "YOUR_CLIENT_SECRET",
        },
        ThingspaceOauth1 = new OAuth2ClientCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            ClientSecret = "YOUR_CLIENT_SECRET",
        },
        Environment = ServerEnvironment.Production,
    };
var client = new VerizonClient(httpClient, options);
```

DI alternative (`services.AddVerizonClient`):

```csharp
services.AddVerizonClient(options =>
    {
        options.VzM2MToken = "YOUR_API_KEY";
        options.SessionToken = "YOUR_API_KEY";
        options.ThingspaceOauth =
            new OAuth2ClientCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
            };
        options.ThingspaceOauth1 =
            new OAuth2ClientCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
            };
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

Every API group is a property on the client (e.g. `client.GbiDeviceActions5`). Source: `VerizonClient.cs`. The only constructor is `VerizonClient(HttpClient httpClient, VerizonClientOptions options)`.

All `VerizonClientOptions` properties (source: `VerizonClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `Server` | `ServerOptions` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `ThingspaceOauth` | `OAuth2ClientCredentials?` |
| `ThingspaceOauthTokenStrategy` | `IOAuth2TokenStrategy<OAuth2ClientCredentials>?` |
| `VzM2MToken` | `string?` |
| `SessionToken` | `string?` |
| `ThingspaceOauth1` | `OAuth2ClientCredentials?` |
| `ThingspaceOauth1TokenStrategy` | `IOAuth2TokenStrategy<OAuth2ClientCredentials>?` |

`RetryOptions` members (namespace `Verizon.Core.Configuration` — add `using Verizon.Core.Configuration;`; source: `Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `SdkException<TError>` (`Core/Exceptions/SdkException.cs`) exposing `.Error` of type `TError`. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`Core/ErrorResponse/RawError.cs`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

Core error types (`Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 229 typed error classes in `Errors/` | `TryGetRawError(out RawError error): bool` | `Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.AccountDevices.GetAccountDeviceInformation(acc, lastSeenDeviceId, protocol);
}
catch (SdkException<GetAccountDeviceInformationError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetFotaV3Result(out var error))
    {
        // Handle 400
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (SdkException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **314 operations**, **229 are Case A (typed)** and **85 are Case B (raw)**.

---

## Operations — by controller (88 groups, 314 operations)

Each links to a sub-page with one row per operation: signature with must-pass-explicitly params and defaults, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `HyperPreciseCredentials`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Parameter names are literal** — signatures are generated code verbatim; in named arguments use the exact parameter names shown (the cancellation-token parameter is named `ct`) | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `GbiDeviceActions5` | 3 | [map/operations/GbiDeviceActions5.md](map/operations/GbiDeviceActions5.md) |
| `AccountDevices` | 2 | [map/operations/AccountDevices.md](map/operations/AccountDevices.md) |
| `AccountRequests` | 1 | [map/operations/AccountRequests.md](map/operations/AccountRequests.md) |
| `AccountServiceController` | 1 | [map/operations/AccountServiceController.md](map/operations/AccountServiceController.md) |
| `AccountSubscriptions` | 1 | [map/operations/AccountSubscriptions.md](map/operations/AccountSubscriptions.md) |
| `Accounts` | 3 | [map/operations/Accounts.md](map/operations/Accounts.md) |
| `AnomalySettings` | 3 | [map/operations/AnomalySettings.md](map/operations/AnomalySettings.md) |
| `AnomalyTriggers` | 5 | [map/operations/AnomalyTriggers.md](map/operations/AnomalyTriggers.md) |
| `AnomalyTriggersV2` | 3 | [map/operations/AnomalyTriggersV2.md](map/operations/AnomalyTriggersV2.md) |
| `Billing` | 4 | [map/operations/Billing.md](map/operations/Billing.md) |
| `CampaignsV2` | 7 | [map/operations/CampaignsV2.md](map/operations/CampaignsV2.md) |
| `CampaignsV3` | 5 | [map/operations/CampaignsV3.md](map/operations/CampaignsV3.md) |
| `ClientLogging` | 6 | [map/operations/ClientLogging.md](map/operations/ClientLogging.md) |
| `CloudConnectorDevices` | 6 | [map/operations/CloudConnectorDevices.md](map/operations/CloudConnectorDevices.md) |
| `CloudConnectorSubscriptions` | 3 | [map/operations/CloudConnectorSubscriptions.md](map/operations/CloudConnectorSubscriptions.md) |
| `ConfigurationFiles` | 2 | [map/operations/ConfigurationFiles.md](map/operations/ConfigurationFiles.md) |
| `ConnectivityCallbacks` | 3 | [map/operations/ConnectivityCallbacks.md](map/operations/ConnectivityCallbacks.md) |
| `CreatePricePlanTriggers` | 1 | [map/operations/CreatePricePlanTriggers.md](map/operations/CreatePricePlanTriggers.md) |
| `DeviceActions` | 7 | [map/operations/DeviceActions.md](map/operations/DeviceActions.md) |
| `DeviceCredentialManagement` | 4 | [map/operations/DeviceCredentialManagement.md](map/operations/DeviceCredentialManagement.md) |
| `DeviceDiagnostics` | 2 | [map/operations/DeviceDiagnostics.md](map/operations/DeviceDiagnostics.md) |
| `DeviceGroups` | 5 | [map/operations/DeviceGroups.md](map/operations/DeviceGroups.md) |
| `DeviceLocationCallbacks` | 4 | [map/operations/DeviceLocationCallbacks.md](map/operations/DeviceLocationCallbacks.md) |
| `DeviceManagement` | 29 | [map/operations/DeviceManagement.md](map/operations/DeviceManagement.md) |
| `DeviceMonitoring` | 2 | [map/operations/DeviceMonitoring.md](map/operations/DeviceMonitoring.md) |
| `DeviceProfileManagement` | 4 | [map/operations/DeviceProfileManagement.md](map/operations/DeviceProfileManagement.md) |
| `DeviceReports` | 3 | [map/operations/DeviceReports.md](map/operations/DeviceReports.md) |
| `DeviceSmsMessaging` | 4 | [map/operations/DeviceSmsMessaging.md](map/operations/DeviceSmsMessaging.md) |
| `DeviceServiceManagement` | 2 | [map/operations/DeviceServiceManagement.md](map/operations/DeviceServiceManagement.md) |
| `DevicesLocationSubscriptions` | 2 | [map/operations/DevicesLocationSubscriptions.md](map/operations/DevicesLocationSubscriptions.md) |
| `DevicesLocations` | 6 | [map/operations/DevicesLocations.md](map/operations/DevicesLocations.md) |
| `DiagnosticsCallbacks` | 3 | [map/operations/DiagnosticsCallbacks.md](map/operations/DiagnosticsCallbacks.md) |
| `DiagnosticsFactoryReset` | 1 | [map/operations/DiagnosticsFactoryReset.md](map/operations/DiagnosticsFactoryReset.md) |
| `DiagnosticsHistory` | 1 | [map/operations/DiagnosticsHistory.md](map/operations/DiagnosticsHistory.md) |
| `DiagnosticsObservations` | 2 | [map/operations/DiagnosticsObservations.md](map/operations/DiagnosticsObservations.md) |
| `DiagnosticsSettings` | 1 | [map/operations/DiagnosticsSettings.md](map/operations/DiagnosticsSettings.md) |
| `DiagnosticsSubscriptions` | 1 | [map/operations/DiagnosticsSubscriptions.md](map/operations/DiagnosticsSubscriptions.md) |
| `EtxAppConfiguration` | 5 | [map/operations/EtxAppConfiguration.md](map/operations/EtxAppConfiguration.md) |
| `EtxRegistration` | 7 | [map/operations/EtxRegistration.md](map/operations/EtxRegistration.md) |
| `Exclusions` | 6 | [map/operations/Exclusions.md](map/operations/Exclusions.md) |
| `FirmwareV1` | 5 | [map/operations/FirmwareV1.md](map/operations/FirmwareV1.md) |
| `FirmwareV3` | 3 | [map/operations/FirmwareV3.md](map/operations/FirmwareV3.md) |
| `GlobalReporting` | 2 | [map/operations/GlobalReporting.md](map/operations/GlobalReporting.md) |
| `HplDeviceManagement` | 1 | [map/operations/HplDeviceManagement.md](map/operations/HplDeviceManagement.md) |
| `HyperPreciseLocationCallbacks` | 3 | [map/operations/HyperPreciseLocationCallbacks.md](map/operations/HyperPreciseLocationCallbacks.md) |
| `IntelligenceServiceController` | 2 | [map/operations/IntelligenceServiceController.md](map/operations/IntelligenceServiceController.md) |
| `ManagingESimProfiles` | 10 | [map/operations/ManagingESimProfiles.md](map/operations/ManagingESimProfiles.md) |
| `Pwn` | 7 | [map/operations/Pwn.md](map/operations/Pwn.md) |
| `PromotionPeriodInformation` | 2 | [map/operations/PromotionPeriodInformation.md](map/operations/PromotionPeriodInformation.md) |
| `RetrieveRatePlanList` | 1 | [map/operations/RetrieveRatePlanList.md](map/operations/RetrieveRatePlanList.md) |
| `RetrieveTheTriggers` | 4 | [map/operations/RetrieveTheTriggers.md](map/operations/RetrieveTheTriggers.md) |
| `SimActions` | 3 | [map/operations/SimActions.md](map/operations/SimActions.md) |
| `SimSecureForIoTLicenses` | 2 | [map/operations/SimSecureForIoTLicenses.md](map/operations/SimSecureForIoTLicenses.md) |
| `Sms` | 3 | [map/operations/Sms.md](map/operations/Sms.md) |
| `SensorInsightsDeviceProfile` | 4 | [map/operations/SensorInsightsDeviceProfile.md](map/operations/SensorInsightsDeviceProfile.md) |
| `SensorInsightsDevices` | 6 | [map/operations/SensorInsightsDevices.md](map/operations/SensorInsightsDevices.md) |
| `SensorInsightsGateways` | 1 | [map/operations/SensorInsightsGateways.md](map/operations/SensorInsightsGateways.md) |
| `SensorInsightsHealthScore` | 2 | [map/operations/SensorInsightsHealthScore.md](map/operations/SensorInsightsHealthScore.md) |
| `SensorInsightsNotificationGroups` | 6 | [map/operations/SensorInsightsNotificationGroups.md](map/operations/SensorInsightsNotificationGroups.md) |
| `SensorInsightsRules` | 2 | [map/operations/SensorInsightsRules.md](map/operations/SensorInsightsRules.md) |
| `SensorInsightsSensors` | 5 | [map/operations/SensorInsightsSensors.md](map/operations/SensorInsightsSensors.md) |
| `SensorInsightsSmartAlertMetrics` | 1 | [map/operations/SensorInsightsSmartAlertMetrics.md](map/operations/SensorInsightsSmartAlertMetrics.md) |
| `SensorInsightsSmartAlerts` | 3 | [map/operations/SensorInsightsSmartAlerts.md](map/operations/SensorInsightsSmartAlerts.md) |
| `SensorInsightsUsers` | 4 | [map/operations/SensorInsightsUsers.md](map/operations/SensorInsightsUsers.md) |
| `ServerLogging` | 1 | [map/operations/ServerLogging.md](map/operations/ServerLogging.md) |
| `ServicePlans` | 1 | [map/operations/ServicePlans.md](map/operations/ServicePlans.md) |
| `SessionManagement` | 3 | [map/operations/SessionManagement.md](map/operations/SessionManagement.md) |
| `SoftwareManagementCallbacksV1` | 3 | [map/operations/SoftwareManagementCallbacksV1.md](map/operations/SoftwareManagementCallbacksV1.md) |
| `SoftwareManagementCallbacksV2` | 4 | [map/operations/SoftwareManagementCallbacksV2.md](map/operations/SoftwareManagementCallbacksV2.md) |
| `SoftwareManagementCallbacksV3` | 4 | [map/operations/SoftwareManagementCallbacksV3.md](map/operations/SoftwareManagementCallbacksV3.md) |
| `SoftwareManagementLicensesV1` | 5 | [map/operations/SoftwareManagementLicensesV1.md](map/operations/SoftwareManagementLicensesV1.md) |
| `SoftwareManagementLicensesV2` | 6 | [map/operations/SoftwareManagementLicensesV2.md](map/operations/SoftwareManagementLicensesV2.md) |
| `SoftwareManagementLicensesV3` | 3 | [map/operations/SoftwareManagementLicensesV3.md](map/operations/SoftwareManagementLicensesV3.md) |
| `SoftwareManagementReportsV1` | 3 | [map/operations/SoftwareManagementReportsV1.md](map/operations/SoftwareManagementReportsV1.md) |
| `SoftwareManagementReportsV2` | 5 | [map/operations/SoftwareManagementReportsV2.md](map/operations/SoftwareManagementReportsV2.md) |
| `SoftwareManagementReportsV3` | 3 | [map/operations/SoftwareManagementReportsV3.md](map/operations/SoftwareManagementReportsV3.md) |
| `SoftwareManagementSubscriptionsV1` | 2 | [map/operations/SoftwareManagementSubscriptionsV1.md](map/operations/SoftwareManagementSubscriptionsV1.md) |
| `SoftwareManagementSubscriptionsV2` | 1 | [map/operations/SoftwareManagementSubscriptionsV2.md](map/operations/SoftwareManagementSubscriptionsV2.md) |
| `SoftwareManagementSubscriptionsV3` | 1 | [map/operations/SoftwareManagementSubscriptionsV3.md](map/operations/SoftwareManagementSubscriptionsV3.md) |
| `Targets` | 5 | [map/operations/Targets.md](map/operations/Targets.md) |
| `ThingSpaceQualityOfServiceApiActions` | 2 | [map/operations/ThingSpaceQualityOfServiceApiActions.md](map/operations/ThingSpaceQualityOfServiceApiActions.md) |
| `UpdatePricePlanTriggers` | 1 | [map/operations/UpdatePricePlanTriggers.md](map/operations/UpdatePricePlanTriggers.md) |
| `UpdateTriggers` | 1 | [map/operations/UpdateTriggers.md](map/operations/UpdateTriggers.md) |
| `UsageTriggerManagement` | 3 | [map/operations/UsageTriggerManagement.md](map/operations/UsageTriggerManagement.md) |
| `WirelessNetworkPerformance` | 5 | [map/operations/WirelessNetworkPerformance.md](map/operations/WirelessNetworkPerformance.md) |
| `DeviceRoleController` | 1 | [map/operations/DeviceRoleController.md](map/operations/DeviceRoleController.md) |
| `EUiccDeviceProfileManagement` | 5 | [map/operations/EUiccDeviceProfileManagement.md](map/operations/EUiccDeviceProfileManagement.md) |
| `MapMessageController` | 4 | [map/operations/MapMessageController.md](map/operations/MapMessageController.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `Models/` and `Errors/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 781 | `Models/` |
| Unions (`AnyOf`) — variant factories + `TryGet…` | 50 | `Models/AnyOf/` |
| Enums (`StringEnum<T>` / `IntEnum<T>`) — C# member names + wire values | 61 | `Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 229 | `Errors/` |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — build with `Type.FromValue("wire")` or the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`).

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `Verizon` |
| Operation controllers (`Api/`) | `Verizon.Api` |
| Records (`Models/`) | `Verizon.Models` |
| Enums (`Models/Enums/`) | `Verizon.Models.Enums` |
| AnyOf unions (`Models/AnyOf/`) | `Verizon.Models.AnyOf` |
| Error classes (`Errors/`) | `Verizon.Errors` |

---

## Servers & auth

**OAuth2 (client credentials).** Set `options.ThingspaceOauth` with your client id and secret; tokens are fetched from `https://thingspace.verizon.com/api/ts/v1/oauth2/token`. `options.ThingspaceOauthTokenStrategy` overrides how tokens are acquired and cached; leave it unset for the SDK's own handling. This is the ThingSpace token, from [Credentials and Tokens](https://thingspace.verizon.com/documentation/api-documentation.html#/http/quick-start/credentials-and-tokens)
  is used

**API key (header `VZ-M2M-Token`).** Set `options.VzM2MToken = "<api_key>"`; sent as the `VZ-M2M-Token` request header. M2M Session Token ([How to generate an M2M session token?]($e/Session%20Management/StartConnectivityManagementSession))

**API key (header `SessionToken`).** Set `options.SessionToken = "<api_key>"`; sent as the `SessionToken` request header. This is the Session/M2M token needed to authenticate the user. It should be acquired by using the ThingSpace APIs. For detail on how to obtain a Session/M2M token please refer to the
- [ThingSpace Quick Start Guide - Obtaining a VZ-M2M Session Token Programmatically](https://thingspace.verizon.com/documentation/api-documentation.html#/http/quick-start/credentials-and-tokens/obtaining-a-vz-m2m-sessiontoken-programmatically)
- or the [ThingSpace API Video Guide 1](https://www.youtube.com/watch?v=QPJQFT3637w) and [ThingSpace API Video Guide 2](https://www.youtube.com/watch?v=hc9udGp4P_s)


**OAuth2 (client credentials).** Set `options.ThingspaceOauth1` with your client id and secret; tokens are fetched from `https://thingspace.verizon.com/api/ts/v1/`. `options.ThingspaceOauth1TokenStrategy` overrides how tokens are acquired and cached; leave it unset for the SDK's own handling. This is where the ThingSpace access token, from [Credentials and Tokens](https://thingspace.verizon.com/documentation/api-documentation.html#/http/quick-start/credentials-and-tokens) is used

**Environments.** `options.Environment` selects the target environment (`Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `Production` | — |
| `ServerEnvironment.Staging` | `Staging` | — |
| `ServerEnvironment.Dev` | `Dev` | — |
| `ServerEnvironment.Qa` | `Qa` | — |
| `ServerEnvironment.MockServerForLimitedAvailabilitySeeQuickStart` | `Mock server for limited availability, see quick start` | — |

**15 server groups.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | `Staging` base URL | `Dev` base URL | `Qa` base URL | `MockServerForLimitedAvailabilitySeeQuickStart` base URL | Override point |
| --- | --- | --- | --- | --- | --- | --- |
| `HyperPreciseCredentials` | `https://thingspace.verizon.com/api/auth/v1` | `https://staging.thingspace.verizon.com/api/auth/v1` | `https://staging.thingspace.verizon.com/api/auth/v1` | `https://thingspace.verizon.com/api/auth/v1` | `https://staging.thingspace.verizon.com/api/auth/v1` | `options.Server.HyperPreciseCredentials.Production.BaseUrl` (and the other environments) |
| `ImpServer` | `https://imp.thingspace.verizon.com` | `https://imp-staging.thingspace.verizon.com` | `https://devmanagement-staging.imp.thingspace.verizon.com` | `https://tsd-nginx-qa-us-east-1.imp.thingspace.verizon.com` | `https://mock-staging.thingspace.verizon.com` | `options.Server.ImpServer.Production.BaseUrl` (and the other environments) |
| `Thingspace` | `https://thingspace.verizon.com/api` | `https://staging.thingspace.verizon.com/api` | `https://devmanagement-staging.thingspace.verizon.com/api` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api` | `https://mock-staging.thingspace.verizon.com/api` | `options.Server.Thingspace.Production.BaseUrl` (and the other environments) |
| `OAuthServer` | `https://thingspace.verizon.com/api/ts/v1` | `https://staging.thingspace.verizon.com/api/ts/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/ts/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/ts/v1` | `https://mock-staging.thingspace.verizon.com/api/ts/v1` | `options.Server.OAuthServer.Production.BaseUrl` (and the other environments) |
| `M2M` | `https://thingspace.verizon.com/api/m2m` | `https://staging.thingspace.verizon.com/api/m2m` | `https://devmanagement-staging.thingspace.verizon.com:80/m2m` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/m2m` | `https://mock-staging.thingspace.verizon.com/api/m2m` | `options.Server.M2M.Production.BaseUrl` (and the other environments) |
| `DeviceLocation` | `https://thingspace.verizon.com/api/loc/v1` | `https://staging.thingspace.verizon.com/api/loc/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/loc/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/loc/v1` | `https://mock-staging.thingspace.verizon.com/api/loc/v1` | `options.Server.DeviceLocation.Production.BaseUrl` (and the other environments) |
| `SubscriptionServer` | `https://thingspace.verizon.com/api/subsc/v1` | `https://staging.thingspace.verizon.com/api/subsc/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/subsc/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/subsc/v1` | `https://mock-staging.thingspace.verizon.com/api/subsc/v1` | `options.Server.SubscriptionServer.Production.BaseUrl` (and the other environments) |
| `SoftwareManagementV1` | `https://thingspace.verizon.com/api/fota/v1` | `https://staging.thingspace.verizon.com/api/fota/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/fota/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/fota/v1` | `https://mock-staging.thingspace.verizon.com/api/fota/v1` | `options.Server.SoftwareManagementV1.Production.BaseUrl` (and the other environments) |
| `SoftwareManagementV2` | `https://thingspace.verizon.com/api/fota/v2` | `https://staging.thingspace.verizon.com/api/fota/v2` | `https://devmanagement-staging.thingspace.verizon.com:80/fota/v2` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/fota/v2` | `https://mock-staging.thingspace.verizon.com/api/fota/v2` | `options.Server.SoftwareManagementV2.Production.BaseUrl` (and the other environments) |
| `SoftwareManagementV3` | `https://thingspace.verizon.com/api/fota/v3` | `https://staging.thingspace.verizon.com/api/fota/v3` | `https://devmanagement-staging.thingspace.verizon.com:80/fota/v3` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/fota/v3` | `https://mock-staging.thingspace.verizon.com/api/fota/v3` | `options.Server.SoftwareManagementV3.Production.BaseUrl` (and the other environments) |
| `DeviceDiagnostics` | `https://thingspace.verizon.com/api/diagnostics/v1` | `https://staging.thingspace.verizon.com/api/diagnostics/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/diagnostics/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/diagnostics/v1` | `https://mock-staging.thingspace.verizon.com/api/diagnostics/v1` | `options.Server.DeviceDiagnostics.Production.BaseUrl` (and the other environments) |
| `CloudConnector` | `https://thingspace.verizon.com/api/cc/v1` | `https://staging.thingspace.verizon.com/api/cc/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/cc/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/cc/v1` | `https://mock-staging.thingspace.verizon.com/api/cc/v1` | `options.Server.CloudConnector.Production.BaseUrl` (and the other environments) |
| `HyperPreciseLocation` | `https://thingspace.verizon.com/api/hyper-precise/v1` | `https://staging.thingspace.verizon.com/api/hyper-precise/v1` | `https://devmanagement-staging.thingspace.verizon.com:80/hyper-precise/v1` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/hyper-precise/v1` | `https://mock-staging.thingspace.verizon.com/api/hyper-precise/v1` | `options.Server.HyperPreciseLocation.Production.BaseUrl` (and the other environments) |
| `Services` | `https://5gedge.verizon.com/api/mec/services` | `https://staging.5gedge.verizon.com/api/mec/services` | `https://devmanagement-staging.5gedge.verizon.com:80/mec/services` | `https://tsd-nginx-qa-us-east-1.5gedge.verizon.com/api/mec/services` | `https://mock-staging.thingspace.verizon.com/api/mec/services` | `options.Server.Services.Production.BaseUrl` (and the other environments) |
| `QualityOfService` | `https://thingspace.verizon.com/api/m2m/v1/devices` | `https://staging.thingspace.verizon.com/api/m2m/v1/devices` | `https://devmanagement-staging.thingspace.verizon.com/api/m2m/v1/devices` | `https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/m2m/v1/devices` | `https://mock-staging.thingspace.verizon.com/api/m2m/v1/devices` | `options.Server.QualityOfService.Production.BaseUrl` (and the other environments) |

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

