using AutoMapper;
using DDDSession.API.Model.Response;
using DDDSession.Domain.DbEntity;

namespace DDDSession.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserInformationResponse, UserInformation>().ReverseMap();
        }
    }
}
