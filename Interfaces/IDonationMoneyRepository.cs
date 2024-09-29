using Ntwalo_APPR6312.Models;

namespace Ntwalo_APPR6312.Interfaces
{
    public interface IDonationMoneyRepository
    {
        Task<IEnumerable<DonationMoney>> GetAll();

        Task<DonationMoney> GetByIdAsync(int id);

        //Task<IEnumerable<DonationMoney>> GetAllDonationMoneyByString(string something);

        bool Add(DonationMoney donationItem);
        bool Update(DonationMoney donationItem);
        bool Delete(DonationMoney donationItem);
        bool Save();
    }
}
