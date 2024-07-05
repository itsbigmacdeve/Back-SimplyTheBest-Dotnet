using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimplyTheBest.Dtos;
using SimplyTheBest.Interfaces;

namespace SimplyTheBest.Data
{
    public class UserRepository : IUserRepository
    {
        public Task<UserDto> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}