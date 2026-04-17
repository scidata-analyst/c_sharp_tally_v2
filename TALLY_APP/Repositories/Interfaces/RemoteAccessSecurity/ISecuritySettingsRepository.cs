using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.RemoteAccessSecurity
{
    /**
     * =====================================================
     * Repository Interface: ISecuritySettingsRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for SecuritySettings entity.
     */
    public interface ISecuritySettingsRepository
    {
        Task<List<SecuritySettings>> GetAllAsync();
        Task<SecuritySettings> GetByIdAsync(long id);
        Task AddAsync(SecuritySettings entity);
        Task UpdateAsync(SecuritySettings entity);
        Task DeleteAsync(long id);
    }
}
