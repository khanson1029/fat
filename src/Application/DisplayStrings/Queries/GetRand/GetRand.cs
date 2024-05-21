using fat.Application.Common.Interfaces;

namespace fat.Application.DisplayStrings.Queries.GetRand;

public record GetRandQuery : IRequest<string>
{
}

public class GetRandQueryValidator : AbstractValidator<GetRandQuery>
{
    public GetRandQueryValidator()
    {
    }
}

public class GetRandQueryHandler : IRequestHandler<GetRandQuery, string>
{
    private readonly IApplicationDbContext _context;

    public GetRandQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    public async Task<string> Handle(GetRandQuery request, CancellationToken cancellationToken)
    {
        List<string> strList = new List<string>(["apple","banana", "square", "oval", "peach"]);
        Random r = new Random();
        return strList[r.Next(0,5)];
    }
}
