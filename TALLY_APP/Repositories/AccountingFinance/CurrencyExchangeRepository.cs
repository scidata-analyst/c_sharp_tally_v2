using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Data;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @class CurrencyExchangeRepository
     * @description Handles database operations for CurrencyExchange using EF Core.
     */
    public class CurrencyExchangeRepository : ICurrencyExchangeRepository
    {
        private readonly AppDbContext _context;

        /**
         * @constructor
         * @param {AppDbContext} context - Database context instance
         */
        public CurrencyExchangeRepository(AppDbContext context)
        {
            _context = context;
        }

        /**
         * @method GetAllAsync
         * @returns {Task<List<CurrencyExchange>>}
         */
        public async Task<List<CurrencyExchange>> GetAllAsync()
        {
            return await _context.Set<CurrencyExchange>().ToListAsync();
        }

        /**
         * @method GetByIdAsync
         * @param {long} id
         * @returns {Task<CurrencyExchange>}
         */
        public async Task<CurrencyExchange> GetByIdAsync(long id)
        {
            return await _context.Set<CurrencyExchange>().FindAsync(id);
        }

        /**
         * @method AddAsync
         * @param {CurrencyExchange} entity
         */
        public async Task AddAsync(CurrencyExchange entity)
        {
            await _context.Set<CurrencyExchange>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method UpdateAsync
         * @param {CurrencyExchange} entity
         */
        public async Task UpdateAsync(CurrencyExchange entity)
        {
            _context.Set<CurrencyExchange>().Update(entity);
            await _context.SaveChangesAsync();
        }

        /**
         * @method DeleteAsync
         * @param {long} id
         */
        public async Task DeleteAsync(long id)
        {
            var entity = await _context.Set<CurrencyExchange>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<CurrencyExchange>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
