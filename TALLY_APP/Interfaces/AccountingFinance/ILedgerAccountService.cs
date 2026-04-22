using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

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
         * Get paginated records with search, sort
         * @param int page
         * @param int pageSize
         * @param string search
         * @param string sortColumn
         * @param string sortDirection
         * @return PaginatedLedgerResponse
         */
        Task<PaginatedLedgerResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");

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
