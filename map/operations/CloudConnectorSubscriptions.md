<!-- Generated file — do not edit; regenerated with the SDK. -->

# CloudConnectorSubscriptions — operations

Accessor: `client.CloudConnectorSubscriptions` · Source: `Api/CloudConnectorSubscriptions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateSubscription

- **Server group**: `CloudConnector`
- **Signature**: `CreateSubscription(CreateSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Subscription`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `Subscription` | `Models/Subscription.cs` |

### DeleteSubscription

- **Server group**: `CloudConnector`
- **Signature**: `DeleteSubscription(DeleteSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionRequest` | `Models/DeleteSubscriptionRequest.cs` |

### QuerySubscription

- **Server group**: `CloudConnector`
- **Signature**: `QuerySubscription(QuerySubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Subscription>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QuerySubscriptionRequest` | `Models/QuerySubscriptionRequest.cs` |
| `Subscription` | `Models/Subscription.cs` |

