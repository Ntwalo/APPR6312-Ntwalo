using Ntwalo_APPR6312.Models;

namespace Ntwalo_APPR6312.Interfaces
{
    public interface ICatagoryRepository
    {
        Task<IEnumerable<Catagory>> GetAll();

        Task<Catagory> GetByIdAsync(int id);

        bool Add(Catagory catagory);
        bool Update(Catagory catagory);
        bool Delete(Catagory catagory);
        bool Save();
    }
}
