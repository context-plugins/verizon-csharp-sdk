using Verizon.Servers;

namespace Verizon;

public class ServerOptions
{
    public HyperPreciseCredentialsOptions HyperPreciseCredentials { get; set; } = new();
    public ImpServerOptions ImpServer { get; set; } = new();
    public ThingspaceOptions Thingspace { get; set; } = new();
    public OauthServerOptions OauthServer { get; set; } = new();
    public M2MOptions M2M { get; set; } = new();
    public DeviceLocationOptions DeviceLocation { get; set; } = new();
    public SubscriptionServerOptions SubscriptionServer { get; set; } = new();
    public SoftwareManagementV1Options SoftwareManagementV1 { get; set; } = new();
    public SoftwareManagementV2Options SoftwareManagementV2 { get; set; } = new();
    public SoftwareManagementV3Options SoftwareManagementV3 { get; set; } = new();
    public DeviceDiagnosticsOptions DeviceDiagnostics { get; set; } = new();
    public CloudConnectorOptions CloudConnector { get; set; } = new();
    public HyperPreciseLocationOptions HyperPreciseLocation { get; set; } = new();
    public ServicesOptions Services { get; set; } = new();
    public QualityOfServiceOptions QualityOfService { get; set; } = new();
}
