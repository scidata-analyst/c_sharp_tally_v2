using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.BankingPayments;

namespace TALLY_APP.Repositories.BankingPayments
{
    /**
     * @interface IPaymentReminderRepository
     * @description Defines database contract for PaymentReminder entity operations.
     */
    public interface IPaymentReminderRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all PaymentReminder records from database.
         * @returns {Task<List<PaymentReminder>>}
         */
        Task<List<PaymentReminder>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<PaymentReminder>}
         */
        Task<PaymentReminder> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {PaymentReminder} entity - Entity model
         */
        Task AddAsync(PaymentReminder entity);

        /**
         * @method UpdateAsync
         * @param {PaymentReminder} entity - Updated entity model
         */
        Task UpdateAsync(PaymentReminder entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
