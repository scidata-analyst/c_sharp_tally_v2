using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Repository Interface: IVoucherEntryRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for VoucherEntry entity.
     */
    public interface IVoucherEntryRepository
    {
        Task<List<VoucherEntry>> GetAllAsync();
        Task<VoucherEntry> GetByIdAsync(long id);
        Task AddAsync(VoucherEntry entity);
        Task UpdateAsync(VoucherEntry entity);
        Task DeleteAsync(long id);
    }
}
