using Ntwalo_APPR6312.Models;

namespace Ntwalo_APPR6312.Interfaces
{
    public interface IDisasterRepository
    {
        Task<IEnumerable<Disaster>> GetAll();

        Task<Disaster> GetByIdAsync(int id);

        Task<IEnumerable<DonationItem>> GetAllDisasterByLocation(string location);

        //Task<IEnumerable<DonationItem>> GetAllDisasterByCatagory(string catagory);

        bool Add(Disaster disaster);
        bool Update(Disaster disaster);
        bool Delete(Disaster disaster);
        bool Save();
    }
}
