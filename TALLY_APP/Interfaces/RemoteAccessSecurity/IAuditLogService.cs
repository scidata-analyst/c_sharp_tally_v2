using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Interfaces.RemoteAccessSecurity
{
    public interface IAuditLogService
    {
        Task<List<AuditLogResponse>> All();
        Task<PaginatedAuditLogResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc");
        Task<AuditLogResponse> View(long id);
        Task<AuditLogResponse> Create(AuditLogRequest request);
        Task<AuditLogResponse> Update(long id, AuditLogRequest request);
        Task<bool> Delete(long id);
    }
}
