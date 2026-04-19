using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @interface IVATServiceTaxRepository
     * @description Defines database contract for VATServiceTax entity operations.
     */
    public interface IVATServiceTaxRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all VATServiceTax records from database.
         * @returns {Task<List<VATServiceTax>>}
         */
        Task<List<VATServiceTax>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<VATServiceTax>}
         */
        Task<VATServiceTax> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {VATServiceTax} entity - Entity model
         */
        Task AddAsync(VATServiceTax entity);

        /**
         * @method UpdateAsync
         * @param {VATServiceTax} entity - Updated entity model
         */
        Task UpdateAsync(VATServiceTax entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
