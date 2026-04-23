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
     */
    public interface IVoucherEntryService
    {
        /**
         * Get all records
         */
        Task<List<VoucherEntryResponse>> All();

        /**
         * Get paginated records with search, sort
         */
        Task<PaginatedVoucherResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");

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
