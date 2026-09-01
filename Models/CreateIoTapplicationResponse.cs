using System.Text.Json.Serialization;
using Verizon.Core.Models;

namespace Verizon.Models;

/// <summary>
/// A success response includes an array of all matching events. Each event includes the full event resource definition.
/// </summary>
public record CreateIoTApplicationResponse
{
    /// <summary>
    /// An application will be created under the user's Azure subscription with this name and of type IOT central.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appName")]
    public string? AppName { get; init; }

    /// <summary>
    /// Part of the user credentials (from Azure) the user needs to use for calling further TS Core APIs for setting up Azure cloud connector.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sharedSecret")]
    public string? SharedSecret { get; init; }

    /// <summary>
    /// An IOT central endpoint the user can use to see the data that is being streamed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
