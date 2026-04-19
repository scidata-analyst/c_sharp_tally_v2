using Microsoft.EntityFrameworkCore;
using TALLY_APP.Models.Dashboard;
using TALLY_APP.Models.AccountingFinance;
using TALLY_APP.Models.InventoryManagement;
using TALLY_APP.Models.GSTTaxation;
using TALLY_APP.Models.PayrollManagement;
using TALLY_APP.Models.BankingPayments;
using TALLY_APP.Models.ReportingAnalytics;
using TALLY_APP.Models.MultiLocationBranch;
using TALLY_APP.Models.RemoteAccessSecurity;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Data
{
    /**
     * =====================================================
     * APPLICATION DB CONTEXT
     * =====================================================
     *
     * Description:
     * Central EF Core DbContext for TALLY system.
     * Auto-generated from database_schema.json
     *
     * Includes:
     * - DbSet mappings
     * - Model configuration entry point
     */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /**
         * DbSet for DashboardWidget
         */
        public DbSet<DashboardWidget> DashboardWidget { get; set; }
        /**
         * DbSet for LedgerAccount
         */
        public DbSet<LedgerAccount> LedgerAccount { get; set; }
        /**
         * DbSet for VoucherEntry
         */
        public DbSet<VoucherEntry> VoucherEntry { get; set; }
        /**
         * DbSet for PartyDirectory
         */
        public DbSet<PartyDirectory> PartyDirectory { get; set; }
        /**
         * DbSet for BankAccount
         */
        public DbSet<BankAccount> BankAccount { get; set; }
        /**
         * DbSet for BankReconciliation
         */
        public DbSet<BankReconciliation> BankReconciliation { get; set; }
        /**
         * DbSet for CurrencyExchange
         */
        public DbSet<CurrencyExchange> CurrencyExchange { get; set; }
        /**
         * DbSet for StockItem
         */
        public DbSet<StockItem> StockItem { get; set; }
        /**
         * DbSet for StockGroup
         */
        public DbSet<StockGroup> StockGroup { get; set; }
        /**
         * DbSet for BatchRegister
         */
        public DbSet<BatchRegister> BatchRegister { get; set; }
        /**
         * DbSet for StockMovement
         */
        public DbSet<StockMovement> StockMovement { get; set; }
        /**
         * DbSet for Godown
         */
        public DbSet<Godown> Godown { get; set; }
        /**
         * DbSet for GSTEntry
         */
        public DbSet<GSTEntry> GSTEntry { get; set; }
        /**
         * DbSet for VATServiceTax
         */
        public DbSet<VATServiceTax> VATServiceTax { get; set; }
        /**
         * DbSet for GSTReturn
         */
        public DbSet<GSTReturn> GSTReturn { get; set; }
        /**
         * DbSet for TDSTCSEntry
         */
        public DbSet<TDSTCSEntry> TDSTCSEntry { get; set; }
        /**
         * DbSet for Employee
         */
        public DbSet<Employee> Employee { get; set; }
        /**
         * DbSet for PayrollRun
         */
        public DbSet<PayrollRun> PayrollRun { get; set; }
        /**
         * DbSet for Payslip
         */
        public DbSet<Payslip> Payslip { get; set; }
        /**
         * DbSet for StatutoryDeduction
         */
        public DbSet<StatutoryDeduction> StatutoryDeduction { get; set; }
        /**
         * DbSet for PaymentEntry
         */
        public DbSet<PaymentEntry> PaymentEntry { get; set; }
        /**
         * DbSet for PaymentReminder
         */
        public DbSet<PaymentReminder> PaymentReminder { get; set; }
        /**
         * DbSet for BankIntegration
         */
        public DbSet<BankIntegration> BankIntegration { get; set; }
        /**
         * DbSet for TrialBalance
         */
        public DbSet<TrialBalance> TrialBalance { get; set; }
        /**
         * DbSet for BalanceSheet
         */
        public DbSet<BalanceSheet> BalanceSheet { get; set; }
        /**
         * DbSet for ProfitLoss
         */
        public DbSet<ProfitLoss> ProfitLoss { get; set; }
        /**
         * DbSet for CashFlowStatement
         */
        public DbSet<CashFlowStatement> CashFlowStatement { get; set; }
        /**
         * DbSet for StockReport
         */
        public DbSet<StockReport> StockReport { get; set; }
        /**
         * DbSet for SalesPurchaseSummary
         */
        public DbSet<SalesPurchaseSummary> SalesPurchaseSummary { get; set; }
        /**
         * DbSet for Branch
         */
        public DbSet<Branch> Branch { get; set; }
        /**
         * DbSet for BranchConsolidation
         */
        public DbSet<BranchConsolidation> BranchConsolidation { get; set; }
        /**
         * DbSet for BranchPerformance
         */
        public DbSet<BranchPerformance> BranchPerformance { get; set; }
        /**
         * DbSet for SystemUser
         */
        public DbSet<SystemUser> SystemUser { get; set; }
        /**
         * DbSet for AuditLog
         */
        public DbSet<AuditLog> AuditLog { get; set; }
        /**
         * DbSet for SecuritySettings
         */
        public DbSet<SecuritySettings> SecuritySettings { get; set; }
        /**
         * DbSet for AutomationRule
         */
        public DbSet<AutomationRule> AutomationRule { get; set; }
        /**
         * DbSet for Budget
         */
        public DbSet<Budget> Budget { get; set; }
        /**
         * DbSet for ForexTransaction
         */
        public DbSet<ForexTransaction> ForexTransaction { get; set; }
        /**
         * DbSet for CustomReport
         */
        public DbSet<CustomReport> CustomReport { get; set; }


        /**
         * Model configuration entry point
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==============================
            // AUTO GENERATED CONFIG SECTION
            // ==============================

            // Configure DeleteBehavior.NoAction to avoid "foreign key not null" and multiple cascade path issues

            modelBuilder.Entity<LedgerAccount>()
                .HasOne(e => e.ParentGroup)
                .WithMany()
                .HasForeignKey(e => e.ParentGroupId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<VoucherEntry>()
                .HasOne(e => e.Party)
                .WithMany()
                .HasForeignKey(e => e.PartyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<VoucherEntry>()
                .HasOne(e => e.BankAccount)
                .WithMany()
                .HasForeignKey(e => e.BankAccountId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BankReconciliation>()
                .HasOne(e => e.BankAccount)
                .WithMany()
                .HasForeignKey(e => e.BankAccountId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StockItem>()
                .HasOne(e => e.StockGroup)
                .WithMany()
                .HasForeignKey(e => e.StockGroupId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BatchRegister>()
                .HasOne(e => e.StockItem)
                .WithMany()
                .HasForeignKey(e => e.ItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StockMovement>()
                .HasOne(e => e.StockItem)
                .WithMany()
                .HasForeignKey(e => e.ItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StockMovement>()
                .HasOne(e => e.FromGodown)
                .WithMany()
                .HasForeignKey(e => e.FromGodownId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StockMovement>()
                .HasOne(e => e.ToGodown)
                .WithMany()
                .HasForeignKey(e => e.ToGodownId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<GSTEntry>()
                .HasOne(e => e.Party)
                .WithMany()
                .HasForeignKey(e => e.PartyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TDSTCSEntry>()
                .HasOne(e => e.Party)
                .WithMany()
                .HasForeignKey(e => e.PartyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PayrollRun>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payslip>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StatutoryDeduction>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PaymentEntry>()
                .HasOne(e => e.Party)
                .WithMany()
                .HasForeignKey(e => e.PartyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PaymentEntry>()
                .HasOne(e => e.BankAccountRelation)
                .WithMany()
                .HasForeignKey(e => e.BankAccountId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PaymentReminder>()
                .HasOne(e => e.Party)
                .WithMany()
                .HasForeignKey(e => e.PartyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BranchConsolidation>()
                .HasOne(e => e.Branch)
                .WithMany()
                .HasForeignKey(e => e.BranchId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuditLog>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ForexTransaction>()
                .HasOne(e => e.Party)
                .WithMany()
                .HasForeignKey(e => e.PartyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ForexTransaction>()
                .HasOne(e => e.CurrencyRelation)
                .WithMany()
                .HasForeignKey(e => e.CurrencyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
