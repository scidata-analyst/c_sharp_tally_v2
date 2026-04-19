using System.Collections.Generic;
using System.Threading.Tasks;
using RemoteAccessSecurity.DTOs.Request;
using RemoteAccessSecurity.DTOs.Response;

namespace TALLY_APP.Interfaces.RemoteAccessSecurity
{
    /**
     * =====================================================
     * Interface: IAuditLogService
     * =====================================================
     *
     * Purpose:
     * Defines contract for AuditLog business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IAuditLogService
    {
        /**
         * Get all records
         */
        Task<List<AuditLogResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<AuditLogResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<AuditLogResponse> View(long id);

        /**
         * Create new record
         */
        Task<AuditLogResponse> Create(AuditLogRequest request);

        /**
         * Update existing record
         */
        Task<AuditLogResponse> Update(long id, AuditLogRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
