using DDDSession.Domain.IRepository;
using MediatR;
using System.Runtime.CompilerServices;

namespace DDDSession.API.Mediator.Command.UserInformation
{
    public class CreateUserInformationCommandHandler : IRequestHandler<CreateUserInformationCommand>
    {
        private readonly IUserInformationRepository _userInformationRepository;
        public CreateUserInformationCommandHandler(IUserInformationRepository userInformationRepository)
        {
            _userInformationRepository = userInformationRepository;
        }
        public async Task<Unit> Handle(CreateUserInformationCommand request, CancellationToken cancellationToken)
        {
            var userinformation = 
            await _userInformationRepository.CreateUserInformationAsync(request);
            throw new NotImplementedException();
        }
    }
}
