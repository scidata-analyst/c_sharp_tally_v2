using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IBankReconciliationService
     * =====================================================
     */
    public interface IBankReconciliationService
    {
        /**
         * Get all records
         */
        Task<List<BankReconciliationResponse>> All();

        /**
         * Get paginated records with search, sort
         */
        Task<PaginatedBankReconciliationResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");

        /**
         * Get single record by ID
         */
        Task<BankReconciliationResponse> View(long id);

        /**
         * Create new record
         */
        Task<BankReconciliationResponse> Create(BankReconciliationRequest request);

        /**
         * Update existing record
         */
        Task<BankReconciliationResponse> Update(long id, BankReconciliationRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
