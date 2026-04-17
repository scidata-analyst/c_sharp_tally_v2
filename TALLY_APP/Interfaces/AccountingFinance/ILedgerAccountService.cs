using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: ILedgerAccountService
     * =====================================================
     *
     * Purpose:
     * Defines contract for LedgerAccount business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ILedgerAccountService
    {
        /**
         * Get all records
         */
        Task<List<LedgerAccountResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<LedgerAccountResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<LedgerAccountResponse> View(long id);

        /**
         * Create new record
         */
        Task<LedgerAccountResponse> Create(LedgerAccountRequest request);

        /**
         * Update existing record
         */
        Task<LedgerAccountResponse> Update(long id, LedgerAccountRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
