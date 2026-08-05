using System.Net.Http;

namespace Verizon.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}