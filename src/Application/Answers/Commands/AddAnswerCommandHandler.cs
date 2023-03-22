using MediatR;

namespace Questionnaire.Application.Answers.Commands;

public class AddAnswerCommandHandler : IRequestHandler<AddAnswerCommand, Unit>
{
    public async Task<Unit> Handle(AddAnswerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}