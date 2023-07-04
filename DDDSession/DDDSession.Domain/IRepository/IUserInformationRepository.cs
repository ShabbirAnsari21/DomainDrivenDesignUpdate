using DDDSession.Domain.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSession.Domain.IRepository
{
    public interface IUserInformationRepository
    {
        Task<IList<UserInformation>> GetAllUserInformation();
        Task CreateUserInformationAsync(UserInformation userInformation);
    }
}
