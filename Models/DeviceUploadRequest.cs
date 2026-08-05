using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DeviceUploadRequest
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }

    [JsonPropertyName("emailAddress")]
    public required string EmailAddress { get; init; }

    [JsonPropertyName("deviceSku")]
    public required string DeviceSku { get; init; }

    [JsonPropertyName("uploadType")]
    public required string UploadType { get; init; }
}
