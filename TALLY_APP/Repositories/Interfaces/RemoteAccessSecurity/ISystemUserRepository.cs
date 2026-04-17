using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.RemoteAccessSecurity
{
    /**
     * =====================================================
     * Repository Interface: ISystemUserRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for SystemUser entity.
     */
    public interface ISystemUserRepository
    {
        Task<List<SystemUser>> GetAllAsync();
        Task<SystemUser> GetByIdAsync(long id);
        Task AddAsync(SystemUser entity);
        Task UpdateAsync(SystemUser entity);
        Task DeleteAsync(long id);
    }
}
