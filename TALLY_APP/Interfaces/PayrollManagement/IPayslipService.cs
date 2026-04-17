using System.Collections.Generic;
using System.Threading.Tasks;
using PayrollManagement.DTOs.Request;
using PayrollManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Interface: IPayslipService
     * =====================================================
     *
     * Purpose:
     * Defines contract for Payslip business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IPayslipService
    {
        /**
         * Get all records
         */
        Task<List<PayslipResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<PayslipResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<PayslipResponse> View(long id);

        /**
         * Create new record
         */
        Task<PayslipResponse> Create(PayslipRequest request);

        /**
         * Update existing record
         */
        Task<PayslipResponse> Update(long id, PayslipRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
