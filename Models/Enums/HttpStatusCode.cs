using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// HTML error code and description.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HttpStatusCode>))]
public sealed record HttpStatusCode : StringEnum<HttpStatusCode>
{
    private HttpStatusCode(string value) : base(value)
    {
    }

    public static readonly HttpStatusCode _100Continue = new("100 CONTINUE");

    public static readonly HttpStatusCode _101SwitchingProtocols = new("101 SWITCHING_PROTOCOLS");

    public static readonly HttpStatusCode _102Processing = new("102 PROCESSING");

    public static readonly HttpStatusCode _103Checkpoint = new("103 CHECKPOINT");

    public static readonly HttpStatusCode _200Ok = new("200 OK");

    public static readonly HttpStatusCode _201Created = new("201 CREATED");

    public static readonly HttpStatusCode _202Accepted = new("202 ACCEPTED");

    public static readonly HttpStatusCode _203NonAuthoritativeInformation = new("203 NON_AUTHORITATIVE_INFORMATION");

    public static readonly HttpStatusCode _204NoContent = new("204 NO_CONTENT");

    public static readonly HttpStatusCode _205ResetContent = new("205 RESET_CONTENT");

    public static readonly HttpStatusCode _206PartialContent = new("206 PARTIAL_CONTENT");

    public static readonly HttpStatusCode _207MultiStatus = new("207 MULTI_STATUS");

    public static readonly HttpStatusCode _208AlreadyReported = new("208 ALREADY_REPORTED");

    public static readonly HttpStatusCode _226ImUsed = new("226 IM_USED");

    public static readonly HttpStatusCode _300MultipleChoices = new("300 MULTIPLE_CHOICES");

    public static readonly HttpStatusCode _301MovedPermanently = new("301 MOVED_PERMANENTLY");

    public static readonly HttpStatusCode _302Found = new("302 FOUND");

    public static readonly HttpStatusCode _302MovedTemporarily = new("302 MOVED_TEMPORARILY");

    public static readonly HttpStatusCode _303SeeOther = new("303 SEE_OTHER");

    public static readonly HttpStatusCode _304NotModified = new("304 NOT_MODIFIED");

    public static readonly HttpStatusCode _305UseProxy = new("305 USE_PROXY");

    public static readonly HttpStatusCode _307TemporaryRedirect = new("307 TEMPORARY_REDIRECT");

    public static readonly HttpStatusCode _308PermanentRedirect = new("308 PERMANENT_REDIRECT");

    public static readonly HttpStatusCode _400BadRequest = new("400 BAD_REQUEST");

    public static readonly HttpStatusCode _401Unauthorized = new("401 UNAUTHORIZED");

    public static readonly HttpStatusCode _402PaymentRequired = new("402 PAYMENT_REQUIRED");

    public static readonly HttpStatusCode _403Forbidden = new("403 FORBIDDEN");

    public static readonly HttpStatusCode _404NotFound = new("404 NOT_FOUND");

    public static readonly HttpStatusCode _405MethodNotAllowed = new("405 METHOD_NOT_ALLOWED");

    public static readonly HttpStatusCode _406NotAcceptable = new("406 NOT_ACCEPTABLE");

    public static readonly HttpStatusCode _407ProxyAuthenticationRequired = new("407 PROXY_AUTHENTICATION_REQUIRED");

    public static readonly HttpStatusCode _408RequestTimeout = new("408 REQUEST_TIMEOUT");

    public static readonly HttpStatusCode _409Conflict = new("409 CONFLICT");

    public static readonly HttpStatusCode _410Gone = new("410 GONE");

    public static readonly HttpStatusCode _411LengthRequired = new("411 LENGTH_REQUIRED");

    public static readonly HttpStatusCode _412PreconditionFailed = new("412 PRECONDITION_FAILED");

    public static readonly HttpStatusCode _413PayloadTooLarge = new("413 PAYLOAD_TOO_LARGE");

    public static readonly HttpStatusCode _413RequestEntityTooLarge = new("413 REQUEST_ENTITY_TOO_LARGE");

    public static readonly HttpStatusCode _414UriTooLong = new("414 URI_TOO_LONG");

    public static readonly HttpStatusCode _414RequestUriTooLong = new("414 REQUEST_URI_TOO_LONG");

    public static readonly HttpStatusCode _415UnsupportedMediaType = new("415 UNSUPPORTED_MEDIA_TYPE");

    public static readonly HttpStatusCode _416RequestedRangeNotSatisfiable = new("416 REQUESTED_RANGE_NOT_SATISFIABLE");

    public static readonly HttpStatusCode _417ExpectationFailed = new("417 EXPECTATION_FAILED");

    public static readonly HttpStatusCode _418IAmATeapot = new("418 I_AM_A_TEAPOT");

    public static readonly HttpStatusCode _419InsufficientSpaceOnResource = new("419 INSUFFICIENT_SPACE_ON_RESOURCE");

    public static readonly HttpStatusCode _420MethodFailure = new("420 METHOD_FAILURE");

    public static readonly HttpStatusCode _421DestinationLocked = new("421 DESTINATION_LOCKED");

    public static readonly HttpStatusCode _422UnprocessableEntity = new("422 UNPROCESSABLE_ENTITY");

    public static readonly HttpStatusCode _423Locked = new("423 LOCKED");

    public static readonly HttpStatusCode _424FailedDependency = new("424 FAILED_DEPENDENCY");

    public static readonly HttpStatusCode _425TooEarly = new("425 TOO_EARLY");

    public static readonly HttpStatusCode _426UpgradeRequired = new("426 UPGRADE_REQUIRED");

    public static readonly HttpStatusCode _428PreconditionRequired = new("428 PRECONDITION_REQUIRED");

    public static readonly HttpStatusCode _429TooManyRequests = new("429 TOO_MANY_REQUESTS");

    public static readonly HttpStatusCode _431RequestHeaderFieldsTooLarge = new("431 REQUEST_HEADER_FIELDS_TOO_LARGE");

    public static readonly HttpStatusCode _451UnavailableForLegalReasons = new("451 UNAVAILABLE_FOR_LEGAL_REASONS");

    public static readonly HttpStatusCode _500InternalServerError = new("500 INTERNAL_SERVER_ERROR");

    public static readonly HttpStatusCode _501NotImplemented = new("501 NOT_IMPLEMENTED");

    public static readonly HttpStatusCode _502BadGateway = new("502 BAD_GATEWAY");

    public static readonly HttpStatusCode _503ServiceUnavailable = new("503 SERVICE_UNAVAILABLE");

    public static readonly HttpStatusCode _504GatewayTimeout = new("504 GATEWAY_TIMEOUT");

    public static readonly HttpStatusCode _505HttpVersionNotSupported = new("505 HTTP_VERSION_NOT_SUPPORTED");

    public static readonly HttpStatusCode _506VariantAlsoNegotiates = new("506 VARIANT_ALSO_NEGOTIATES");

    public static readonly HttpStatusCode _507InsufficientStorage = new("507 INSUFFICIENT_STORAGE");

    public static readonly HttpStatusCode _508LoopDetected = new("508 LOOP_DETECTED");

    public static readonly HttpStatusCode _509BandwidthLimitExceeded = new("509 BANDWIDTH_LIMIT_EXCEEDED");

    public static readonly HttpStatusCode _510NotExtended = new("510 NOT_EXTENDED");

    public static readonly HttpStatusCode _511NetworkAuthenticationRequired = new("511 NETWORK_AUTHENTICATION_REQUIRED");

    public static HttpStatusCode FromValue(string value) => FromValueCore(value);
}
