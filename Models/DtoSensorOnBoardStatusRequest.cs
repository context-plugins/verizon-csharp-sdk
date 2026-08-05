using System.Text.Json.Serialization;

namespace Verizon.Models;

public record DtoSensorOnBoardStatusRequest
{
    /// <summary>
    /// The numeric account name, which must include leading zeros
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountname")]
    public string? Accountname { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gatewayidentifier")]
    public Gatewayidentifier? Gatewayidentifier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onboarding")]
    public Onboarding? Onboarding { get; init; }
}
