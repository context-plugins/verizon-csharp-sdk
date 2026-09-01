using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// The request body must include the UUID of the subscription that you want to update plus any properties that you want to change.
/// </summary>
public record CreateIoTApplicationRequest
{
    /// <summary>
    /// A user defined name for the application being deployed in Azure IoT Central.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appName")]
    public string? AppName { get; init; }

    /// <summary>
    /// The ThingSpace ID of the authenticating billing account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAccountID")]
    public string? BillingAccountId { get; init; }

    /// <summary>
    /// The Azure ClientID of the associated Azure target account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientID")]
    public string? ClientId { get; init; }

    /// <summary>
    /// The Azure Client Secret of the associated Azure target account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; init; }

    /// <summary>
    /// The “email IDs” to be added to/sent to with this API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailIDs")]
    public string? EmailIDs { get; init; }

    /// <summary>
    /// The Azure Resource group of the associated Azure target account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourcegroup")]
    public string? Resourcegroup { get; init; }

    /// <summary>
    /// This is the reference Azure IoT Central application developed by Verizon.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sampleIOTcApp")]
    public string? SampleIoTcApp { get; init; }

    /// <summary>
    /// The Azure Subscription ID of the associated Azure target account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionID")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// The Azure Tenant ID of the associated Azure target account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tenantID")]
    public string? TenantId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
