using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record AccountDetails
{
    /// <summary>
    /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9-]{3,32}$")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// user defined name of organization
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationName")]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]{3,32}$")]
    public string? OrganizationName { get; init; }

    /// <summary>
    /// Flag set to indicate if account details can be edited or not. Default is "true".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isProvisioningAllowed")]
    public bool? IsProvisioningAllowed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carriers")]
    public IReadOnlyList<Carrier>? Carriers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("features")]
    public IReadOnlyList<Feature>? Features { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlans")]
    public IReadOnlyList<CarrierServicePlan>? ServicePlans { get; init; }
}
