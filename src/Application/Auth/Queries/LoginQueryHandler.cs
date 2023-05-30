using MediatR;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Data;

namespace Questionnaire.Application.Auth.Queries;

public class LoginQueryHandler : IRequestHandler<LoginQuery, AuthResult>
{
    private readonly IApplicationDbContext _context;
    private readonly IJwtGenerator _jwtGenerator;

    public LoginQueryHandler(IApplicationDbContext context, IJwtGenerator jwtGenerator)
    {
        _context = context;
        _jwtGenerator = jwtGenerator;
    }

    public async Task<AuthResult> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == request.Email);
        if (user is null)
        {
            throw new Exception("User with the given email does not exist.");
        }

        if (user.Password != request.Password)
        {
            throw new Exception("invalid password");
        }

        var token = _jwtGenerator.GenerateToken(user);
        return new AuthResult(user, token);
    }
}