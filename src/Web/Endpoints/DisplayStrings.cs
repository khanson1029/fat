using fat.Application.DisplayStrings.Queries.GetHello;
using fat.Application.DisplayStrings.Queries.GetRand;

namespace fat.Web.Endpoints;

public class DisplayStrings : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetHello, "hello")
            .MapGet(GetRand, "rand");
    }

    public async Task<string> GetHello(ISender sender)
    {
        return await sender.Send(new GetHelloQuery());
    }

    public async Task<string> GetRand(ISender sender)
    {
        return await sender.Send(new GetRandQuery());
    }
}
