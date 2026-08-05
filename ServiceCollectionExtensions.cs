using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Verizon;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddVerizonClient(Action<VerizonClientOptions>? configure = null)
        {
            var options = new VerizonClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    options.Logging =
                        options.Logging with
                        {
                            LoggerFactory = options.Logging.LoggerFactory ?? sp.GetService<ILoggerFactory>()
                        };
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new VerizonClient(httpClient, options);
                });
            return services;
        }
    }
}
