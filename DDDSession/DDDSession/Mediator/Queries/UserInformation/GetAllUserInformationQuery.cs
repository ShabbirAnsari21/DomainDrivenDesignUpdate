using DDDSession.API.Model.Response;
using MediatR;

namespace DDDSession.API.Mediator.Queries.UserInformation
{
    public record GetAllUserInformationQuery : IRequest<IList<DDDSession.Domain.DbEntity.UserInformation>>
    {
    }
}
