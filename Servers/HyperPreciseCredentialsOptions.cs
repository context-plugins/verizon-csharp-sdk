using Verizon.Core.Models;

namespace Verizon.Servers;

public class HyperPreciseCredentialsOptions
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
        public string BaseUrl { get; set; } = "https://thingspace.verizon.com/api/auth/v1";
    }

    public class StagingOptions
    {
        public string BaseUrl { get; set; } = "https://staging.thingspace.verizon.com/api/auth/v1";
    }

    public class DevOptions
    {
        public string BaseUrl { get; set; } = "https://staging.thingspace.verizon.com/api/auth/v1";
    }

    public class QaOptions
    {
        public string BaseUrl { get; set; } = "https://thingspace.verizon.com/api/auth/v1";
    }

    public class MockServerForLimitedAvailabilitySeeQuickStartOptions
    {
        public string BaseUrl { get; set; } = "https://staging.thingspace.verizon.com/api/auth/v1";
    }
}
