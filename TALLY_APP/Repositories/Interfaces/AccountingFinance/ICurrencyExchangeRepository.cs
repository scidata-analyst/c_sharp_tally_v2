using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Repository Interface: ICurrencyExchangeRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for CurrencyExchange entity.
     */
    public interface ICurrencyExchangeRepository
    {
        Task<List<CurrencyExchange>> GetAllAsync();
        Task<CurrencyExchange> GetByIdAsync(long id);
        Task AddAsync(CurrencyExchange entity);
        Task UpdateAsync(CurrencyExchange entity);
        Task DeleteAsync(long id);
    }
}
