using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Verizon.Models;

/// <summary>
/// The request body identifies the devices to upload.
/// </summary>
public record UploadsActivatesDeviceRequest
{
    /// <summary>
    /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The email address that the report should be sent to when the upload is complete.
    /// </summary>
    [JsonPropertyName("emailAddress")]
    public required string EmailAddress { get; init; }

    /// <summary>
    /// The stock keeping unit that identifies the type of devices in the upload and activation.
    /// </summary>
    [JsonPropertyName("deviceSku")]
    public required string DeviceSku { get; init; }

    /// <summary>
    /// The format of the device identifiers in the upload and activation.
    /// </summary>
    [JsonPropertyName("uploadType")]
    public required string UploadType { get; init; }

    /// <summary>
    /// The service plan code that you want to assign to all specified devices.
    /// </summary>
    [JsonPropertyName("servicePlan")]
    public required string ServicePlan { get; init; }

    /// <summary>
    /// The pool from which your device IP addresses is derived.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrierIpPoolName")]
    public string? CarrierIpPoolName { get; init; }

    /// <summary>
    /// The Zip code of the location where the line of service is primarily used, or a Zip code that you have been told to use with these devices.
    /// </summary>
    [JsonPropertyName("mdnZipCode")]
    public required string MdnZipCode { get; init; }

    /// <summary>
    /// The devices to upload, specified by device IDs in a format matching uploadType.
    /// </summary>
    [JsonPropertyName("devices")]
    public required IReadOnlyList<DeviceList> Devices { get; init; }
}
