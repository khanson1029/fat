using fat.Application.Common.Interfaces;

namespace fat.Application.DisplayStrings.Commands.CreateDisplayString;

public record CreateDisplayStringCommand : IRequest<string>
{
}

public class CreateDisplayStringCommandValidator : AbstractValidator<CreateDisplayStringCommand>
{
    public CreateDisplayStringCommandValidator()
    {
    }
}

public class CreateDisplayStringCommandHandler : IRequestHandler<CreateDisplayStringCommand, string>
{
    private readonly IApplicationDbContext _context;

    public CreateDisplayStringCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

    public async Task<string> Handle(CreateDisplayStringCommand request, CancellationToken cancellationToken)
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

    {
        throw new NotImplementedException();
    }
}
