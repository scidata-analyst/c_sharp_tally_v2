using System.Collections.Generic;
using System.Threading.Tasks;
using AccountingFinance.DTOs.Request;
using AccountingFinance.DTOs.Response;

namespace TALLY_APP.Interfaces.AccountingFinance
{
    /**
     * =====================================================
     * Interface: IPartyDirectoryService
     * =====================================================
     *
     * Purpose:
     * Defines contract for PartyDirectory business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IPartyDirectoryService
    {
        /**
         * Get all records
         */
        Task<List<PartyDirectoryResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<PartyDirectoryResponse>> Index();

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
