using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @class SecuritySettingsRepository
     * @description Handles database operations for SecuritySettings using EF Core.
     */
    public class SecuritySettingsRepository
    {
        private readonly ApplicationDbContext _context;

        public SecuritySettingsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SecuritySettings>> All()
        {
            return await _context.Set<SecuritySettings>().ToListAsync();
        }

        public async Task<(List<SecuritySettings> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "desc")
        {
            var query = _context.Set<SecuritySettings>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.EncryptionType.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "encryptiontype" => ascending ? query.OrderBy(x => x.EncryptionType) : query.OrderByDescending(x => x.EncryptionType),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "lastbackup" => ascending ? query.OrderBy(x => x.LastBackup) : query.OrderByDescending(x => x.LastBackup),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<SecuritySettings?> View(long id)
        {
            return await _context.Set<SecuritySettings>().FindAsync(id);
        }

        public async Task Create(SecuritySettings entity)
        {
            await _context.Set<SecuritySettings>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(SecuritySettings entity)
        {
            _context.Set<SecuritySettings>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<SecuritySettings>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<SecuritySettings>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
