using Verizon.Core;
using Verizon.Core.Authentication;
using Verizon.Core.Authentication.ApiKey;
using Verizon.Core.Authentication.OAuth2;
using Verizon.Core.Authentication.OAuth2.ClientCredentials;

namespace Verizon;

internal sealed class AuthSchemes
{
    public IAuthScheme VzM2MToken { get; }
    public IAuthScheme SessionToken { get; }
    public IAuthScheme ThingspaceOauth { get; }
    public IAuthScheme ThingspaceOauth1 { get; }

    public AuthSchemes(VerizonClientOptions options, Server server, RawClient rawClient)
    {
        VzM2MToken = ApiKeyHeaderScheme.Create("VZ-M2M-Token", options.VzM2MToken);
        SessionToken = ApiKeyHeaderScheme.Create("SessionToken", options.SessionToken);
        ThingspaceOauth =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.ThingspaceOauth,
                options.ThingspaceOauthTokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.OauthServer("/oauth2/token"), rawClient));
        ThingspaceOauth1 =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.ThingspaceOauth1,
                options.ThingspaceOauth1TokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.OauthServer("/"), rawClient));
    }
}
