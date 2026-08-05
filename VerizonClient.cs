using System.Net.Http;
using Verizon.Api;
using Verizon.Core;
using Verizon.Core.Logging;
using Verizon.Core.Models;

namespace Verizon;

/// <summary>
/// "The Connection Planner is a service that provides devices windows to connect to their backend APIs. The service validates device access permissions and processes valid devices asynchronously. For each batch, it retrieves device connectivity windows from the RAN KPI Data Application, and sends callbacks back to customers via UWS-Callback for both successful and failed device requests."
/// </summary>
public sealed class VerizonClient
{
    public VerizonClient(HttpClient httpClient, VerizonClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "VerizonClient/v1.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "v1.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "VerizonClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        var auth = new AuthSchemes(options, server, rawClient);
        GbiDeviceActions5 = new GbiDeviceActions5(rawClient, server, auth);
        AccountDevices = new AccountDevices(rawClient, server, auth);
        AccountRequests = new AccountRequests(rawClient, server, auth);
        AccountServiceController = new AccountServiceController(rawClient, server, auth);
        AccountSubscriptions = new AccountSubscriptions(rawClient, server, auth);
        Accounts = new Accounts(rawClient, server, auth);
        AnomalySettings = new AnomalySettings(rawClient, server, auth);
        AnomalyTriggers = new AnomalyTriggers(rawClient, server, auth);
        AnomalyTriggersV2 = new AnomalyTriggersV2(rawClient, server, auth);
        Billing = new Billing(rawClient, server, auth);
        CampaignsV2 = new CampaignsV2(rawClient, server, auth);
        CampaignsV3 = new CampaignsV3(rawClient, server, auth);
        ClientLogging = new ClientLogging(rawClient, server, auth);
        CloudConnectorDevices = new CloudConnectorDevices(rawClient, server, auth);
        CloudConnectorSubscriptions = new CloudConnectorSubscriptions(rawClient, server, auth);
        ConfigurationFiles = new ConfigurationFiles(rawClient, server, auth);
        ConnectivityCallbacks = new ConnectivityCallbacks(rawClient, server, auth);
        CreatePricePlanTriggers = new CreatePricePlanTriggers(rawClient, server, auth);
        DeviceActions = new DeviceActions(rawClient, server, auth);
        DeviceCredentialManagement = new DeviceCredentialManagement(rawClient, server, auth);
        DeviceDiagnostics = new DeviceDiagnostics(rawClient, server, auth);
        DeviceGroups = new DeviceGroups(rawClient, server, auth);
        DeviceLocationCallbacks = new DeviceLocationCallbacks(rawClient, server, auth);
        DeviceManagement = new DeviceManagement(rawClient, server, auth);
        DeviceMonitoring = new DeviceMonitoring(rawClient, server, auth);
        DeviceProfileManagement = new DeviceProfileManagement(rawClient, server, auth);
        DeviceReports = new DeviceReports(rawClient, server, auth);
        DeviceSmsMessaging = new DeviceSmsMessaging(rawClient, server, auth);
        DeviceServiceManagement = new DeviceServiceManagement(rawClient, server, auth);
        DevicesLocationSubscriptions = new DevicesLocationSubscriptions(rawClient, server, auth);
        DevicesLocations = new DevicesLocations(rawClient, server, auth);
        DiagnosticsCallbacks = new DiagnosticsCallbacks(rawClient, server, auth);
        DiagnosticsFactoryReset = new DiagnosticsFactoryReset(rawClient, server, auth);
        DiagnosticsHistory = new DiagnosticsHistory(rawClient, server, auth);
        DiagnosticsObservations = new DiagnosticsObservations(rawClient, server, auth);
        DiagnosticsSettings = new DiagnosticsSettings(rawClient, server, auth);
        DiagnosticsSubscriptions = new DiagnosticsSubscriptions(rawClient, server, auth);
        EtxappConfiguration = new EtxappConfiguration(rawClient, server, auth);
        Etxregistration = new Etxregistration(rawClient, server, auth);
        Exclusions = new Exclusions(rawClient, server, auth);
        FirmwareV1 = new FirmwareV1(rawClient, server, auth);
        FirmwareV3 = new FirmwareV3(rawClient, server, auth);
        GlobalReporting = new GlobalReporting(rawClient, server, auth);
        HplDeviceManagement = new HplDeviceManagement(rawClient, server, auth);
        HyperPreciseLocationCallbacks = new HyperPreciseLocationCallbacks(rawClient, server, auth);
        IntelligenceServiceController = new IntelligenceServiceController(rawClient, server, auth);
        ManagingESimProfiles = new ManagingESimProfiles(rawClient, server, auth);
        Pwn = new Pwn(rawClient, server, auth);
        PromotionPeriodInformation = new PromotionPeriodInformation(rawClient, server, auth);
        RetrieveRatePlanList = new RetrieveRatePlanList(rawClient, server, auth);
        RetrieveTheTriggers = new RetrieveTheTriggers(rawClient, server, auth);
        SimActions = new SimActions(rawClient, server, auth);
        SimSecureForIoTLicenses = new SimSecureForIoTLicenses(rawClient, server, auth);
        Sms = new Sms(rawClient, server, auth);
        SensorInsightsDeviceProfile = new SensorInsightsDeviceProfile(rawClient, server, auth);
        SensorInsightsDevices = new SensorInsightsDevices(rawClient, server, auth);
        SensorInsightsGateways = new SensorInsightsGateways(rawClient, server, auth);
        SensorInsightsHealthScore = new SensorInsightsHealthScore(rawClient, server, auth);
        SensorInsightsNotificationGroups = new SensorInsightsNotificationGroups(rawClient, server, auth);
        SensorInsightsRules = new SensorInsightsRules(rawClient, server, auth);
        SensorInsightsSensors = new SensorInsightsSensors(rawClient, server, auth);
        SensorInsightsSmartAlertMetrics = new SensorInsightsSmartAlertMetrics(rawClient, server, auth);
        SensorInsightsSmartAlerts = new SensorInsightsSmartAlerts(rawClient, server, auth);
        SensorInsightsUsers = new SensorInsightsUsers(rawClient, server, auth);
        ServerLogging = new ServerLogging(rawClient, server, auth);
        ServicePlans = new ServicePlans(rawClient, server, auth);
        SessionManagement = new SessionManagement(rawClient, server, auth);
        SoftwareManagementCallbacksV1 = new SoftwareManagementCallbacksV1(rawClient, server, auth);
        SoftwareManagementCallbacksV2 = new SoftwareManagementCallbacksV2(rawClient, server, auth);
        SoftwareManagementCallbacksV3 = new SoftwareManagementCallbacksV3(rawClient, server, auth);
        SoftwareManagementLicensesV1 = new SoftwareManagementLicensesV1(rawClient, server, auth);
        SoftwareManagementLicensesV2 = new SoftwareManagementLicensesV2(rawClient, server, auth);
        SoftwareManagementLicensesV3 = new SoftwareManagementLicensesV3(rawClient, server, auth);
        SoftwareManagementReportsV1 = new SoftwareManagementReportsV1(rawClient, server, auth);
        SoftwareManagementReportsV2 = new SoftwareManagementReportsV2(rawClient, server, auth);
        SoftwareManagementReportsV3 = new SoftwareManagementReportsV3(rawClient, server, auth);
        SoftwareManagementSubscriptionsV1 = new SoftwareManagementSubscriptionsV1(rawClient, server, auth);
        SoftwareManagementSubscriptionsV2 = new SoftwareManagementSubscriptionsV2(rawClient, server, auth);
        SoftwareManagementSubscriptionsV3 = new SoftwareManagementSubscriptionsV3(rawClient, server, auth);
        Targets = new Targets(rawClient, server, auth);
        ThingSpaceQualityOfServiceApiActions = new ThingSpaceQualityOfServiceApiActions(rawClient, server, auth);
        UpdatePricePlanTriggers = new UpdatePricePlanTriggers(rawClient, server, auth);
        UpdateTriggers = new UpdateTriggers(rawClient, server, auth);
        UsageTriggerManagement = new UsageTriggerManagement(rawClient, server, auth);
        WirelessNetworkPerformance = new WirelessNetworkPerformance(rawClient, server, auth);
        DeviceRoleController = new DeviceRoleController(rawClient, server, auth);
        EUiccDeviceProfileManagement = new EUiccDeviceProfileManagement(rawClient, server, auth);
        MapMessageController = new MapMessageController(rawClient, server, auth);
    }

    /// <summary>
    /// Activate devices or retrieve device attributes.
    /// </summary>
    public GbiDeviceActions5 GbiDeviceActions5 { get; }

    /// <summary>
    /// Device information for an account.
    /// </summary>
    public AccountDevices AccountDevices { get; }

    /// <summary>
    /// Get the status of asynchronous reqeusts.
    /// </summary>
    public AccountRequests AccountRequests { get; }

    /// <summary>
    /// Account Information for a specified Account Name.
    /// </summary>
    public AccountServiceController AccountServiceController { get; }

    public AccountSubscriptions AccountSubscriptions { get; }

    /// <summary>
    /// Get information about an account or account leads.
    /// </summary>
    public Accounts Accounts { get; }

    /// <summary>
    /// Choose what level and interval of alerting for anomalies detected.
    /// </summary>
    public AnomalySettings AnomalySettings { get; }

    /// <summary>
    /// Set the threshold of notification for anomalies detected.
    /// </summary>
    public AnomalyTriggers AnomalyTriggers { get; }

    public AnomalyTriggersV2 AnomalyTriggersV2 { get; }

    public Billing Billing { get; }

    /// <summary>
    /// Schedule, retrieve or cancel scheduled FOTA campaigns.
    /// </summary>
    public CampaignsV2 CampaignsV2 { get; }

    /// <summary>
    /// Schedule, retrieve or cancel scheduled FOTA campaigns.
    /// </summary>
    public CampaignsV3 CampaignsV3 { get; }

    /// <summary>
    /// Device logs stored on the device itself.
    /// </summary>
    public ClientLogging ClientLogging { get; }

    public CloudConnectorDevices CloudConnectorDevices { get; }

    public CloudConnectorSubscriptions CloudConnectorSubscriptions { get; }

    public ConfigurationFiles ConfigurationFiles { get; }

    /// <summary>
    /// Manage subscriptions to asynchronous webhook messages.
    /// </summary>
    public ConnectivityCallbacks ConnectivityCallbacks { get; }

    /// <summary>
    /// Create rules to trigger changes for price plans based on usage
    /// </summary>
    public CreatePricePlanTriggers CreatePricePlanTriggers { get; }

    /// <summary>
    /// Device management for either Verizon (lead) or Global (local) profiles.
    /// </summary>
    public DeviceActions DeviceActions { get; }

    /// <summary>
    /// API endpoints for managing HPL device credentials
    /// </summary>
    public DeviceCredentialManagement DeviceCredentialManagement { get; }

    /// <summary>
    /// Helps to create &amp; manage diagnostics
    /// </summary>
    public DeviceDiagnostics DeviceDiagnostics { get; }

    /// <summary>
    /// Manage device groups.
    /// </summary>
    public DeviceGroups DeviceGroups { get; }

    /// <summary>
    /// Receive notifications from the API.
    /// </summary>
    public DeviceLocationCallbacks DeviceLocationCallbacks { get; }

    /// <summary>
    /// Manage device connectivity and get device history.
    /// </summary>
    public DeviceManagement DeviceManagement { get; }

    /// <summary>
    /// Monitor device reachability and connection status.
    /// </summary>
    public DeviceMonitoring DeviceMonitoring { get; }

    public DeviceProfileManagement DeviceProfileManagement { get; }

    /// <summary>
    /// Check device usage
    /// </summary>
    public DeviceReports DeviceReports { get; }

    /// <summary>
    /// Send Short Message Service (SMS) messages to devices
    /// </summary>
    public DeviceSmsMessaging DeviceSmsMessaging { get; }

    /// <summary>
    /// Check status and enable or disable service for Hyper Precise
    /// </summary>
    public DeviceServiceManagement DeviceServiceManagement { get; }

    /// <summary>
    /// Get an account's location service subscription status and usage.
    /// </summary>
    public DevicesLocationSubscriptions DevicesLocationSubscriptions { get; }

    /// <summary>
    /// Locate devices.
    /// </summary>
    public DevicesLocations DevicesLocations { get; }

    public DiagnosticsCallbacks DiagnosticsCallbacks { get; }

    public DiagnosticsFactoryReset DiagnosticsFactoryReset { get; }

    public DiagnosticsHistory DiagnosticsHistory { get; }

    public DiagnosticsObservations DiagnosticsObservations { get; }

    public DiagnosticsSettings DiagnosticsSettings { get; }

    public DiagnosticsSubscriptions DiagnosticsSubscriptions { get; }

    /// <summary>
    /// Manage geofence-based application configurations.
    /// </summary>
    public EtxappConfiguration EtxappConfiguration { get; }

    /// <summary>
    /// Manage device registration and connection.
    /// </summary>
    public Etxregistration Etxregistration { get; }

    /// <summary>
    /// Exclude devices from location services.
    /// </summary>
    public Exclusions Exclusions { get; }

    /// <summary>
    /// Schedule and monitor firmware upgrades.
    /// </summary>
    public FirmwareV1 FirmwareV1 { get; }

    /// <summary>
    /// State of Firmware across devices in the account.
    /// </summary>
    public FirmwareV3 FirmwareV3 { get; }

    /// <summary>
    /// Use these endpoints to determine the status of requests or the history of device provisioning.
    /// </summary>
    public GlobalReporting GlobalReporting { get; }

    /// <summary>
    /// Manage the devices on the account
    /// </summary>
    public HplDeviceManagement HplDeviceManagement { get; }

    /// <summary>
    /// Manage callback listeners for Hyper Precise
    /// </summary>
    public HyperPreciseLocationCallbacks HyperPreciseLocationCallbacks { get; }

    /// <summary>
    /// ThingSpace Intelligence is an offering of integrated connectivity and service management.
    /// </summary>
    public IntelligenceServiceController IntelligenceServiceController { get; }

    /// <summary>
    /// Manage Global IoT Orchestration device profiles for either Verizon (lead) or Global (local).
    /// </summary>
    public ManagingESimProfiles ManagingESimProfiles { get; }

    public Pwn Pwn { get; }

    /// <summary>
    /// Retrieve status and information about the promotion period for using a pseudo-MDN (Mobile Device Number))
    /// </summary>
    public PromotionPeriodInformation PromotionPeriodInformation { get; }

    /// <summary>
    /// Retrive a list of the rate plans associated with the account
    /// </summary>
    public RetrieveRatePlanList RetrieveRatePlanList { get; }

    /// <summary>
    /// Retrieve the triggers associated with the feature and the account.
    /// </summary>
    public RetrieveTheTriggers RetrieveTheTriggers { get; }

    /// <summary>
    /// Activate and Deactivate the SIM.
    /// </summary>
    public SimActions SimActions { get; }

    public SimSecureForIoTLicenses SimSecureForIoTLicenses { get; }

    /// <summary>
    /// Exchange Short Message Service (SMS) messages with devices.
    /// </summary>
    public Sms Sms { get; }

    /// <summary>
    /// Create and manage device profile information
    /// </summary>
    public SensorInsightsDeviceProfile SensorInsightsDeviceProfile { get; }

    /// <summary>
    /// Device tasks and information
    /// </summary>
    public SensorInsightsDevices SensorInsightsDevices { get; }

    /// <summary>
    /// Query gateway information
    /// </summary>
    public SensorInsightsGateways SensorInsightsGateways { get; }

    /// <summary>
    /// Monitor the health of devices and the network
    /// </summary>
    public SensorInsightsHealthScore SensorInsightsHealthScore { get; }

    /// <summary>
    /// Create and manage groups to recieve notifications and alerts
    /// </summary>
    public SensorInsightsNotificationGroups SensorInsightsNotificationGroups { get; }

    /// <summary>
    /// Create and manage rules
    /// </summary>
    public SensorInsightsRules SensorInsightsRules { get; }

    /// <summary>
    /// Sensor tasks and information
    /// </summary>
    public SensorInsightsSensors SensorInsightsSensors { get; }

    /// <summary>
    /// Retrieve tallies of alerts from a recent daily period
    /// </summary>
    public SensorInsightsSmartAlertMetrics SensorInsightsSmartAlertMetrics { get; }

    /// <summary>
    /// Rules based alerts
    /// </summary>
    public SensorInsightsSmartAlerts SensorInsightsSmartAlerts { get; }

    /// <summary>
    /// Create user accounts and manage user roles and permissions
    /// </summary>
    public SensorInsightsUsers SensorInsightsUsers { get; }

    /// <summary>
    /// Device logs on the server.
    /// </summary>
    public ServerLogging ServerLogging { get; }

    /// <summary>
    /// Get a list of service plans in an account.
    /// </summary>
    public ServicePlans ServicePlans { get; }

    /// <summary>
    /// Start and end Connectivity Management sessions.
    /// </summary>
    public SessionManagement SessionManagement { get; }

    /// <summary>
    /// Register and deregister callback endpoints.
    /// </summary>
    public SoftwareManagementCallbacksV1 SoftwareManagementCallbacksV1 { get; }

    /// <summary>
    /// Find registered callbacks or create, update and delete a registered callback.
    /// </summary>
    public SoftwareManagementCallbacksV2 SoftwareManagementCallbacksV2 { get; }

    /// <summary>
    /// Find registered callbacks or create, update and delete a registered callback.
    /// </summary>
    public SoftwareManagementCallbacksV3 SoftwareManagementCallbacksV3 { get; }

    /// <summary>
    /// Assign Software Management Services license to devices <b>Note:</b>These endpoints have been deprecated. Please use the <b>v3</b> endpoints.
    /// </summary>
    public SoftwareManagementLicensesV1 SoftwareManagementLicensesV1 { get; }

    /// <summary>
    /// License status and assignment.
    /// </summary>
    public SoftwareManagementLicensesV2 SoftwareManagementLicensesV2 { get; }

    /// <summary>
    /// License status and assignment.
    /// </summary>
    public SoftwareManagementLicensesV3 SoftwareManagementLicensesV3 { get; }

    /// <summary>
    /// Status and history information.
    /// </summary>
    public SoftwareManagementReportsV1 SoftwareManagementReportsV1 { get; }

    /// <summary>
    /// Status of a campaign per device.
    /// </summary>
    public SoftwareManagementReportsV2 SoftwareManagementReportsV2 { get; }

    /// <summary>
    /// Status of a campaign per device.
    /// </summary>
    public SoftwareManagementReportsV3 SoftwareManagementReportsV3 { get; }

    /// <summary>
    /// View Software Management Services subscription status.
    /// </summary>
    public SoftwareManagementSubscriptionsV1 SoftwareManagementSubscriptionsV1 { get; }

    /// <summary>
    /// Information about current FOTA subscriptions.
    /// </summary>
    public SoftwareManagementSubscriptionsV2 SoftwareManagementSubscriptionsV2 { get; }

    /// <summary>
    /// Information about current FOTA subscriptions.
    /// </summary>
    public SoftwareManagementSubscriptionsV3 SoftwareManagementSubscriptionsV3 { get; }

    public Targets Targets { get; }

    /// <summary>
    /// Subscribe or Unsubscribe to the ThingSpace Quality of Service API.
    /// </summary>
    public ThingSpaceQualityOfServiceApiActions ThingSpaceQualityOfServiceApiActions { get; }

    /// <summary>
    /// Update rules to trigger changes for price plans based on usage
    /// </summary>
    public UpdatePricePlanTriggers UpdatePricePlanTriggers { get; }

    /// <summary>
    /// Updates the trigger threshold values for alerts.
    /// </summary>
    public UpdateTriggers UpdateTriggers { get; }

    public UsageTriggerManagement UsageTriggerManagement { get; }

    /// <summary>
    /// Run reports to query current network conditions, historic network conditions, see what wireless technologies are supported in your area or qualify and address for Fixed Wireless Access (FWA).
    /// </summary>
    public WirelessNetworkPerformance WirelessNetworkPerformance { get; }

    public DeviceRoleController DeviceRoleController { get; }

    public EUiccDeviceProfileManagement EUiccDeviceProfileManagement { get; }

    /// <summary>
    /// Endpoints for ingesting, querying, and deleting V2X MAP messages.
    /// </summary>
    public MapMessageController MapMessageController { get; }
}
