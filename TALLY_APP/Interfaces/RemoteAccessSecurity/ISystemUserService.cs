using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Interfaces.RemoteAccessSecurity
{
    /**
     * =====================================================
     * Interface: ISystemUserService
     * =====================================================
     *
     * Purpose:
     * Defines contract for SystemUser business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ISystemUserService
    {
        /**
         * Get all records
         */
        Task<List<SystemUserResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<SystemUserResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<SystemUserResponse> View(long id);

        /**
         * Create new record
         */
        Task<SystemUserResponse> Create(SystemUserRequest request);

        /**
         * Update existing record
         */
        Task<SystemUserResponse> Update(long id, SystemUserRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
