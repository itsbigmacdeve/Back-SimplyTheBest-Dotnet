using System.Collections.Generic;
using System.Threading.Tasks;
using SimplyTheBest.Dtos;
using SimplyTheBest.Entities;


namespace SimplyTheBest.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDto>> GetUsersAsync();

        Task<UserDto> GetUserByIdAsync(int id);
    }
}