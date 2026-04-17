using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.RemoteAccessSecurity
{
    /**
     * =====================================================
     * Repository Interface: IAuditLogRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for AuditLog entity.
     */
    public interface IAuditLogRepository
    {
        Task<List<AuditLog>> GetAllAsync();
        Task<AuditLog> GetByIdAsync(long id);
        Task AddAsync(AuditLog entity);
        Task UpdateAsync(AuditLog entity);
        Task DeleteAsync(long id);
    }
}
