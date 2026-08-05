# Verizon

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Verizon SDK for .NET provides access to the [Verizon REST APIs](https://thingspace.verizon.com/documentation/apis/connectivity-management/working-with-verizon/about-callback-services/best-practices.html) from .NET applications.

"The Connection Planner is a service that provides devices windows to connect to their backend APIs. The service validates device access permissions and processes valid devices asynchronously. For each batch, it retrieves device connectivity windows from the RAN KPI Data Application, and sends callbacks back to customers via UWS-Callback for both successful and failed device requests."

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/Verizon.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [VerizonClientOptions](VerizonClientOptions.cs).

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

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [VerizonClientOptions](VerizonClientOptions.cs).

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

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `VerizonClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
