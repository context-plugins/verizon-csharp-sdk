using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Verizon.Models;

public record GetAccountInformationResponseforplanner
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The numeric name of the account, including leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// The list of carrier names with profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carriers")]
    [MaxLength(5)]
    public IReadOnlyList<string>? Carriers { get; init; }

    /// <summary>
    /// a list of features associated with the resident profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("features")]
    [MaxLength(50)]
    public IReadOnlyList<string>? Features { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipPools")]
    [MaxLength(50)]
    public IReadOnlyList<Ippoolforplanner>? IpPools { get; init; }

    /// <summary>
    /// A flag indicating if provisioning is allowed (true) or provisioning is locked (false).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isProvisioningAllowed")]
    public bool? IsProvisioningAllowed { get; init; }

    /// <summary>
    /// The user assigned organization name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organizationName")]
    public string? OrganizationName { get; init; }

    /// <summary>
    /// A list of service plans associated with the resident profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("servicePlans")]
    [MaxLength(10)]
    public IReadOnlyList<ServicePlanResponseforplanner>? ServicePlans { get; init; }
}
