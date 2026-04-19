using System.Collections.Generic;
using System.Threading.Tasks;
using PayrollManagement.DTOs.Request;
using PayrollManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Interface: IPayrollRunService
     * =====================================================
     *
     * Purpose:
     * Defines contract for PayrollRun business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IPayrollRunService
    {
        /**
         * Get all records
         */
        Task<List<PayrollRunResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<PayrollRunResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<PayrollRunResponse> View(long id);

        /**
         * Create new record
         */
        Task<PayrollRunResponse> Create(PayrollRunRequest request);

        /**
         * Update existing record
         */
        Task<PayrollRunResponse> Update(long id, PayrollRunRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
