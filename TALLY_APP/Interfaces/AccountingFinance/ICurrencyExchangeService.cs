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
     *
     * Purpose:
     * Defines contract for CurrencyExchange business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ICurrencyExchangeService
    {
        /**
         * Get all records
         */
        Task<List<CurrencyExchangeResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<CurrencyExchangeResponse>> Index();

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
