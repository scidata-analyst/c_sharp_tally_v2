using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AccountingFinance;
using TALLY_APP.DTOs.Response.AccountingFinance;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IPartyDirectoryService
     * =====================================================
     */
    public interface IPartyDirectoryService
    {
        /**
         * Get all records
         */
        Task<List<PartyDirectoryResponse>> All();

        /**
         * Get paginated records with search, sort
         */
        Task<PaginatedPartyResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");

        /**
         * Get single record by ID
         */
        Task<PartyDirectoryResponse> View(long id);

        /**
         * Create new record
         */
        Task<PartyDirectoryResponse> Create(PartyDirectoryRequest request);

        /**
         * Update existing record
         */
        Task<PartyDirectoryResponse> Update(long id, PartyDirectoryRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
