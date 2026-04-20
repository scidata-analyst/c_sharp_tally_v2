using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Interfaces.RemoteAccessSecurity
{
    /**
     * =====================================================
     * Interface: ISecuritySettingsService
     * =====================================================
     *
     * Purpose:
     * Defines contract for SecuritySettings business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ISecuritySettingsService
    {
        /**
         * Get all records
         */
        Task<List<SecuritySettingsResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<SecuritySettingsResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<SecuritySettingsResponse> View(long id);

        /**
         * Create new record
         */
        Task<SecuritySettingsResponse> Create(SecuritySettingsRequest request);

        /**
         * Update existing record
         */
        Task<SecuritySettingsResponse> Update(long id, SecuritySettingsRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
