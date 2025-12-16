using Microsoft.AspNetCore.Routing;

namespace StaticEndpoints;

public interface IEndpoint
{
    static abstract void AddRoute(IEndpointRouteBuilder builder);
}
