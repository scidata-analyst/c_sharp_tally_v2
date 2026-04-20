using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IVoucherEntryService
     * =====================================================
     *
     * Purpose:
     * Defines contract for VoucherEntry business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IVoucherEntryService
    {
        /**
         * Get all records
         */
        Task<List<VoucherEntryResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<VoucherEntryResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<VoucherEntryResponse> View(long id);

        /**
         * Create new record
         */
        Task<VoucherEntryResponse> Create(VoucherEntryRequest request);

        /**
         * Update existing record
         */
        Task<VoucherEntryResponse> Update(long id, VoucherEntryRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
