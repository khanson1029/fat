using fat.Application.Common.Interfaces;

namespace fat.Application.DisplayStrings.Queries.GetHello;

public record GetHelloQuery : IRequest<string>
{
}

public class GetHelloQueryValidator : AbstractValidator<GetHelloQuery>
{
    public GetHelloQueryValidator()
    {
    }
}

public class GetHelloQueryHandler : IRequestHandler<GetHelloQuery, string>
{
    private readonly IApplicationDbContext _context;

    public GetHelloQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    public async Task<string> Handle(GetHelloQuery request, CancellationToken cancellationToken)
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    {
        return "Hello";
    }
}
