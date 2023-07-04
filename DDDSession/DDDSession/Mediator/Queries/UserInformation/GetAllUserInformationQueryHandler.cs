using DDDSession.API.Model.Response;
using DDDSession.Domain.IRepository;
using MediatR;

namespace DDDSession.API.Mediator.Queries.UserInformation
{
    public class GetAllUserInformationQueryHandler : IRequestHandler<GetAllUserInformationQuery, IList<DDDSession.Domain.DbEntity.UserInformation>>
    {
        private readonly IUserInformationRepository _userInformationRepository;
        public GetAllUserInformationQueryHandler(IUserInformationRepository userInformationRepository)
        {
            _userInformationRepository = userInformationRepository;
        }
        public async Task<IList<DDDSession.Domain.DbEntity.UserInformation>> Handle(GetAllUserInformationQuery request, CancellationToken cancellationToken)
        {
            return await _userInformationRepository.GetAllUserInformation();
        }
    }
}
