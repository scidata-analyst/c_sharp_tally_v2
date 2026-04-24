using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @class AuditLogRepository
     * @description Handles database operations for AuditLog using EF Core.
     */
    public class AuditLogRepository
    {
        private readonly ApplicationDbContext _context;

        public AuditLogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AuditLog>> All()
        {
            return await _context.Set<AuditLog>()
                .Include(x => x.User)
                .ToListAsync();
        }

        public async Task<(List<AuditLog> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "desc")
        {
            var query = _context.Set<AuditLog>()
                .Include(x => x.User)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.UserName.ToLower().Contains(search) ||
                    x.Module.ToLower().Contains(search) ||
                    x.Action.ToLower().Contains(search) ||
                    x.IpAddress.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "username" => ascending ? query.OrderBy(x => x.UserName) : query.OrderByDescending(x => x.UserName),
                "module" => ascending ? query.OrderBy(x => x.Module) : query.OrderByDescending(x => x.Module),
                "action" => ascending ? query.OrderBy(x => x.Action) : query.OrderByDescending(x => x.Action),
                "ipaddress" => ascending ? query.OrderBy(x => x.IpAddress) : query.OrderByDescending(x => x.IpAddress),
                "timestamp" => ascending ? query.OrderBy(x => x.Timestamp) : query.OrderByDescending(x => x.Timestamp),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<AuditLog?> View(long id)
        {
            return await _context.Set<AuditLog>()
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(AuditLog entity)
        {
            await _context.Set<AuditLog>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(AuditLog entity)
        {
            _context.Set<AuditLog>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<AuditLog>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<AuditLog>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
