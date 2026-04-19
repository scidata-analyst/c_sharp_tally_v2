using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IBankAccountService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BankAccount business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBankAccountService
    {
        /**
         * Get all records
         */
        Task<List<BankAccountResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BankAccountResponse>> Index();

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
