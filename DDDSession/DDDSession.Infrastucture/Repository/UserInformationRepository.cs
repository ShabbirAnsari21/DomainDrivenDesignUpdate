using DDDSession.Domain.DbEntity;
using DDDSession.Domain.IRepository;
using DDDSession.Infrastucture.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSession.Infrastucture.Repository
{
    public class UserInformationRepository : IUserInformationRepository
    {
        private readonly ApplicationDbContext _context;
        public UserInformationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IList<UserInformation>> GetAllUserInformation()
        {
            return await _context.UserInformation.ToListAsync();
        }
        public async Task CreateUserInformationAsync(UserInformation userInformation)
        {
            await _context.UserInformation.AddAsync(userInformation);
            await _context.SaveChangesAsync();
        }
    }
}
