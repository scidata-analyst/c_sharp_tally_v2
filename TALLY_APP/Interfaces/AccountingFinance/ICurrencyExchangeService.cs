using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: ICurrencyExchangeService
     * =====================================================
     */
    public interface ICurrencyExchangeService
    {
        /**
         * Get all records
         */
        Task<List<CurrencyExchangeResponse>> All();

        /**
         * Get paginated records with search, sort
         */
        Task<PaginatedCurrencyResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");

        /**
         * Get single record by ID
         */
        Task<CurrencyExchangeResponse> View(long id);

        /**
         * Create new record
         */
        Task<CurrencyExchangeResponse> Create(CurrencyExchangeRequest request);

        /**
         * Update existing record
         */
        Task<CurrencyExchangeResponse> Update(long id, CurrencyExchangeRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
