using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Repository Interface: IPartyDirectoryRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for PartyDirectory entity.
     */
    public interface IPartyDirectoryRepository
    {
        Task<List<PartyDirectory>> GetAllAsync();
        Task<PartyDirectory> GetByIdAsync(long id);
        Task AddAsync(PartyDirectory entity);
        Task UpdateAsync(PartyDirectory entity);
        Task DeleteAsync(long id);
    }
}
