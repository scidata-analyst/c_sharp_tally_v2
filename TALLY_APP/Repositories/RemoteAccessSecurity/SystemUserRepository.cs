using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @class SystemUserRepository
     * @description Handles database operations for SystemUser using EF Core.
     */
    public class SystemUserRepository
    {
        private readonly ApplicationDbContext _context;

        public SystemUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SystemUser>> All()
        {
            return await _context.Set<SystemUser>().ToListAsync();
        }

        public async Task<(List<SystemUser> items, int totalCount)> Index(
            int page = 1,
            int pageSize = 10,
            string search = "",
            string sortColumn = "Id",
            string sortDirection = "asc")
        {
            var query = _context.Set<SystemUser>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x =>
                    x.FullName.ToLower().Contains(search) ||
                    x.Email.ToLower().Contains(search) ||
                    x.Role.ToLower().Contains(search) ||
                    x.Status.ToLower().Contains(search));
            }

            int totalCount = await query.CountAsync();

            bool ascending = sortDirection.ToLower() == "asc";
            query = sortColumn.ToLower() switch
            {
                "fullname" => ascending ? query.OrderBy(x => x.FullName) : query.OrderByDescending(x => x.FullName),
                "email" => ascending ? query.OrderBy(x => x.Email) : query.OrderByDescending(x => x.Email),
                "role" => ascending ? query.OrderBy(x => x.Role) : query.OrderByDescending(x => x.Role),
                "status" => ascending ? query.OrderBy(x => x.Status) : query.OrderByDescending(x => x.Status),
                "lastlogin" => ascending ? query.OrderBy(x => x.LastLogin) : query.OrderByDescending(x => x.LastLogin),
                _ => ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id),
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);
            var items = await query.ToListAsync();
            return (items, totalCount);
        }

        public async Task<SystemUser?> View(long id)
        {
            return await _context.Set<SystemUser>().FindAsync(id);
        }

        public async Task Create(SystemUser entity)
        {
            await _context.Set<SystemUser>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(SystemUser entity)
        {
            _context.Set<SystemUser>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await _context.Set<SystemUser>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<SystemUser>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
