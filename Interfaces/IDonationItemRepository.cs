using Ntwalo_APPR6312.Models;

namespace Ntwalo_APPR6312.Interfaces
{
    public interface IDonationItemRepository
    {
        Task<IEnumerable<DonationItem>> GetAll();

        Task<DonationItem> GetByIdAsync(int id);

        Task<IEnumerable<DonationItem>> GetAllDonationItemsByCatagory(string catagory);

        bool Add(DonationItem donationItem);
        bool Update(DonationItem donationItem);
        bool Delete(DonationItem donationItem);
        bool Save();
    }
}
