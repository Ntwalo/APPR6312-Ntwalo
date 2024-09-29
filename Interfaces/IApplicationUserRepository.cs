using Ntwalo_APPR6312.Models;

namespace Ntwalo_APPR6312.Interfaces
{
    public interface IApplicationUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAll();

        Task<ApplicationUser> GetByIdAsync(int id);

        Task<IEnumerable<ApplicationUser>> GetUserByUserName(string userName);

        bool Add(ApplicationUser applicationUser);
        bool Update(ApplicationUser applicationUser);
        bool Delete(ApplicationUser applicationUser);
        bool Save();
    }
}
