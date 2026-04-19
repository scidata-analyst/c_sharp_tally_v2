using System.Collections.Generic;
using System.Threading.Tasks;
using PayrollManagement.DTOs.Request;
using PayrollManagement.DTOs.Response;

namespace TALLY_APP.Interfaces.PayrollManagement
{
    /**
     * =====================================================
     * Interface: IEmployeeService
     * =====================================================
     *
     * Purpose:
     * Defines contract for Employee business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IEmployeeService
    {
        /**
         * Get all records
         */
        Task<List<EmployeeResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<EmployeeResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<EmployeeResponse> View(long id);

        /**
         * Create new record
         */
        Task<EmployeeResponse> Create(EmployeeRequest request);

        /**
         * Update existing record
         */
        Task<EmployeeResponse> Update(long id, EmployeeRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
