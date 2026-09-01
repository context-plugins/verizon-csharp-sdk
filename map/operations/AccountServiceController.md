<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountServiceController — operations

Accessor: `client.AccountServiceController` · Source: `Api/AccountServiceController.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountInformationUsingGet

- **Signature**: `GetAccountInformationUsingGet(string accountName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetAccountInformationResponseforplanner`
- **Error**: `SdkException<GetAccountInformationUsingGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestErrorResponseforplanner(out RestErrorResponseforplanner)` [400, 403, 404, 406, 429] · `TryGetAuthRestErrorResponseforplanner(out AuthRestErrorResponseforplanner)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountInformationResponseforplanner` | `Models/GetAccountInformationResponseforplanner.cs` |
| `GetAccountInformationUsingGetError` | `Errors/GetAccountInformationUsingGetError.cs` |
| `RestErrorResponseforplanner` | `Models/RestErrorResponseforplanner.cs` |
| `AuthRestErrorResponseforplanner` | `Models/AuthRestErrorResponseforplanner.cs` |

