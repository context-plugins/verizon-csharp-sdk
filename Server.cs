using Verizon.Core.Models;
using Verizon.Servers;

namespace Verizon;

public class Server
{
    private readonly ServerEnvironment _environment;
    private readonly ServerOptions _options;

    internal Server(ServerEnvironment environment, ServerOptions options)
    {
        _environment = environment;
        _options = options;
    }

    internal UrlTemplate HyperPreciseCredentials(string path) =>
        _options.HyperPreciseCredentials.Resolve(_environment, path);
    internal UrlTemplate ImpServer(string path) => _options.ImpServer.Resolve(_environment, path);
    internal UrlTemplate Thingspace(string path) => _options.Thingspace.Resolve(_environment, path);
    internal UrlTemplate OAuthServer(string path) => _options.OAuthServer.Resolve(_environment, path);
    internal UrlTemplate M2M(string path) => _options.M2M.Resolve(_environment, path);
    internal UrlTemplate DeviceLocation(string path) => _options.DeviceLocation.Resolve(_environment, path);
    internal UrlTemplate SubscriptionServer(string path) =>
        _options.SubscriptionServer.Resolve(_environment, path);
    internal UrlTemplate SoftwareManagementV1(string path) =>
        _options.SoftwareManagementV1.Resolve(_environment, path);
    internal UrlTemplate SoftwareManagementV2(string path) =>
        _options.SoftwareManagementV2.Resolve(_environment, path);
    internal UrlTemplate SoftwareManagementV3(string path) =>
        _options.SoftwareManagementV3.Resolve(_environment, path);
    internal UrlTemplate DeviceDiagnostics(string path) =>
        _options.DeviceDiagnostics.Resolve(_environment, path);
    internal UrlTemplate CloudConnector(string path) => _options.CloudConnector.Resolve(_environment, path);
    internal UrlTemplate HyperPreciseLocation(string path) =>
        _options.HyperPreciseLocation.Resolve(_environment, path);
    internal UrlTemplate Services(string path) => _options.Services.Resolve(_environment, path);
    internal UrlTemplate QualityOfService(string path) => _options.QualityOfService.Resolve(_environment, path);
}
