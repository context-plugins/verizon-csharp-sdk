using Verizon.Core.Authentication.OAuth2;
using Verizon.Core.Authentication.OAuth2.ClientCredentials;
using Verizon.Core.Configuration;
using Verizon.Servers;

namespace Verizon;

public class VerizonClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// This is the ThingSpace token, from <see href="https://thingspace.verizon.com/documentation/api-documentation.html#/http/quick-start/credentials-and-tokens">Credentials and Tokens</see>
    ///   is used
    /// </summary>
    public OAuth2ClientCredentials? ThingspaceOauth { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? ThingspaceOauthTokenStrategy { get; set; }
    /// <summary>
    /// M2M Session Token (<see href="$e/Session%20Management/StartConnectivityManagementSession">How to generate an M2M session token?</see>)
    /// </summary>
    public string? VzM2MToken { get; set; }
    /// <summary>
    /// This is the Session/M2M token needed to authenticate the user. It should be acquired by using the ThingSpace APIs. For detail on how to obtain a Session/M2M token please refer to the
    /// - <see href="https://thingspace.verizon.com/documentation/api-documentation.html#/http/quick-start/credentials-and-tokens/obtaining-a-vz-m2m-sessiontoken-programmatically">ThingSpace Quick Start Guide - Obtaining a VZ-M2M Session Token Programmatically</see>
    /// - or the <see href="https://www.youtube.com/watch?v=QPJQFT3637w">ThingSpace API Video Guide 1</see> and <see href="https://www.youtube.com/watch?v=hc9udGp4P_s">ThingSpace API Video Guide 2</see>
    /// </summary>
    public string? SessionToken { get; set; }
    /// <summary>
    /// This is where the ThingSpace access token, from <see href="https://thingspace.verizon.com/documentation/api-documentation.html#/http/quick-start/credentials-and-tokens">Credentials and Tokens</see> is used
    /// </summary>
    public OAuth2ClientCredentials? ThingspaceOauth1 { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? ThingspaceOauth1TokenStrategy { get; set; }
}
