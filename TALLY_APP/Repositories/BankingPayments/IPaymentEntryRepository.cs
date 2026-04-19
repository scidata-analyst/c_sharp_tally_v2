using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @interface IPaymentEntryRepository
     * @description Defines database contract for PaymentEntry entity operations.
     */
    public interface IPaymentEntryRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all PaymentEntry records from database.
         * @returns {Task<List<PaymentEntry>>}
         */
        Task<List<PaymentEntry>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<PaymentEntry>}
         */
        Task<PaymentEntry> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {PaymentEntry} entity - Entity model
         */
        Task AddAsync(PaymentEntry entity);

        /**
         * @method UpdateAsync
         * @param {PaymentEntry} entity - Updated entity model
         */
        Task UpdateAsync(PaymentEntry entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
