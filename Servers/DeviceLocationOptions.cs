using Verizon.Core.Models;

namespace Verizon.Servers;

public class DeviceLocationOptions
{
    public ProductionOptions Production { get; set; } = new();
    public StagingOptions Staging { get; set; } = new();
    public DevOptions Dev { get; set; } = new();
    public QaOptions Qa { get; set; } = new();
    public MockServerForLimitedAvailabilitySeeQuickStartOptions MockServerForLimitedAvailabilitySeeQuickStart { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Staging.BaseUrl, path, []),
            () => new UrlTemplate(Dev.BaseUrl, path, []),
            () => new UrlTemplate(Qa.BaseUrl, path, []),
            () => new UrlTemplate(MockServerForLimitedAvailabilitySeeQuickStart.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://thingspace.verizon.com/api/loc/v1";
    }

    public class StagingOptions
    {
        public string BaseUrl { get; set; } = "https://staging.thingspace.verizon.com/api/loc/v1";
    }

    public class DevOptions
    {
        public string BaseUrl { get; set; } = "https://devmanagement-staging.thingspace.verizon.com:80/loc/v1";
    }

    public class QaOptions
    {
        public string BaseUrl { get; set; } = "https://tsd-nginx-qa-us-east-1.thingspace.verizon.com/api/loc/v1";
    }

    public class MockServerForLimitedAvailabilitySeeQuickStartOptions
    {
        public string BaseUrl { get; set; } = "https://mock-staging.thingspace.verizon.com/api/loc/v1";
    }
}
