using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IBankAccountService
     * =====================================================
     */
    public interface IBankAccountService
    {
        /**
         * Get all records
         */
        Task<List<BankAccountResponse>> All();

        /**
         * Get paginated records with search, sort
         */
        Task<PaginatedBankAccountResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");

        /**
         * Get single record by ID
         */
        Task<BankAccountResponse> View(long id);

        /**
         * Create new record
         */
        Task<BankAccountResponse> Create(BankAccountRequest request);

        /**
         * Update existing record
         */
        Task<BankAccountResponse> Update(long id, BankAccountRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
