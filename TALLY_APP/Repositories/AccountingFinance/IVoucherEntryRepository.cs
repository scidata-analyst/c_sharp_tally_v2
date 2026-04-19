using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @interface IVoucherEntryRepository
     * @description Defines database contract for VoucherEntry entity operations.
     */
    public interface IVoucherEntryRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all VoucherEntry records from database.
         * @returns {Task<List<VoucherEntry>>}
         */
        Task<List<VoucherEntry>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<VoucherEntry>}
         */
        Task<VoucherEntry> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {VoucherEntry} entity - Entity model
         */
        Task AddAsync(VoucherEntry entity);

        /**
         * @method UpdateAsync
         * @param {VoucherEntry} entity - Updated entity model
         */
        Task UpdateAsync(VoucherEntry entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
