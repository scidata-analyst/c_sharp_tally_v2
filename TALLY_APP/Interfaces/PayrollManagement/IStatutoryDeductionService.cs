using System.Collections.Generic;
using System.Threading.Tasks;
using PayrollManagement.DTOs.Request;
using PayrollManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Interface: IStatutoryDeductionService
     * =====================================================
     *
     * Purpose:
     * Defines contract for StatutoryDeduction business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IStatutoryDeductionService
    {
        /**
         * Get all records
         */
        Task<List<StatutoryDeductionResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<StatutoryDeductionResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<StatutoryDeductionResponse> View(long id);

        /**
         * Create new record
         */
        Task<StatutoryDeductionResponse> Create(StatutoryDeductionRequest request);

        /**
         * Update existing record
         */
        Task<StatutoryDeductionResponse> Update(long id, StatutoryDeductionRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
