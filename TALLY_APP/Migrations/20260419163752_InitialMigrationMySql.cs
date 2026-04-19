using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TALLY_APP.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationMySql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "automation_rule",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RuleName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RuleType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Frequency = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NextRun = table.Column<DateTime>(type: "date", nullable: false),
                    LastRun = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_automation_rule", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "balance_sheet",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShareCapital = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ReservesSurplus = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SundryCreditors = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GstPayable = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalLiabilities = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FixedAssets = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StockInTrade = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SundryDebtors = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CashBank = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalAssets = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balance_sheet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bank_account",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BankName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IfscCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpeningBalance = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CurrentBalance = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank_account", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bank_integration",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BankName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiKey = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiSecret = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastSync = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank_integration", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "branch",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BranchName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BranchCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityLocation = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BranchManager = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gstin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Revenue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StockValue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "branch_performance",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BranchName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpeningStock = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Received = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Sold = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ClosingStock = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Revenue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Target = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AchievedPercentage = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch_performance", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "budget",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CostCenter = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnnualBudget = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SpentYTD = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Remaining = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PercentageUsed = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_budget", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cash_flow_statement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NetProfit = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Depreciation = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IncreaseInDebtors = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetFromOperations = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PurchaseOfAssets = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetCashFlow = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cash_flow_statement", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "currency_exchange",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CurrencyName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrencyCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Symbol = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BuyRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SellRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currency_exchange", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "custom_report",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReportName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Module = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Format = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QueryConfig = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastGenerated = table.Column<DateTime>(type: "datetime", nullable: false),
                    Schedule = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custom_report", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dashboard_widget",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WidgetType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataSource = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Configuration = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dashboard_widget", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JoiningDate = table.Column<DateTime>(type: "date", nullable: false),
                    Department = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Designation = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BasicSalary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Hra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Allowances = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PanNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AadharNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PfApplicable = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EsiApplicable = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "godown",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GodownName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manager = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsedPercentage = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StockValue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_godown", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gst_return",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReturnType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DueDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalOutward = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TaxCollected = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalInward = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ItcAvailable = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetPayable = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FiledDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gst_return", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ledger_account",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LedgerName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LedgerCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GroupName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpeningBalance = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    BalanceType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Currency = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    ParentGroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ledger_account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ledger_account_ledger_account_ParentGroupId",
                        column: x => x.ParentGroupId,
                        principalTable: "ledger_account",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "party_directory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PartyType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gstin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PanNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreditLimit = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreditPeriod = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_party_directory", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "profit_loss",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalesRevenue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    OtherIncome = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GrossIncome = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CostOfGoodsSold = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    EmployeeCosts = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AdminOverheads = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetProfit = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profit_loss", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sales_purchase_summary",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalSales = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalPurchases = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GrossMargin = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ReturnOnSales = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales_purchase_summary", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "security_settings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastBackup = table.Column<DateTime>(type: "datetime", nullable: false),
                    BackupSchedule = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CloudBackup = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TwoFactorAuth = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ssl = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncryptionType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_security_settings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stock_group",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentGroup = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemsCount = table.Column<int>(type: "int", nullable: false),
                    ValuationMethod = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalValue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_group", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stock_report",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpeningQty = table.Column<int>(type: "int", nullable: false),
                    StockIn = table.Column<int>(type: "int", nullable: false),
                    StockOut = table.Column<int>(type: "int", nullable: false),
                    ClosingQty = table.Column<int>(type: "int", nullable: false),
                    StockValue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_report", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "system_user",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModuleAccess = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_user", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trial_balance",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GroupName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpeningDr = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    OpeningCr = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransactionDr = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TransactionCr = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ClosingDr = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ClosingCr = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trial_balance", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vat_service_tax",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OutputTax = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    InputTax = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetTaxPayable = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vat_service_tax", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bank_reconciliation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BankAccountId = table.Column<long>(type: "bigint", nullable: true),
                    StatementDate = table.Column<DateTime>(type: "date", nullable: false),
                    BankBalance = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    BookBalance = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UnreconciledAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PendingItems = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReconciledAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank_reconciliation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bank_reconciliation_bank_account_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "bank_account",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "branch_consolidation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BranchId = table.Column<long>(type: "bigint", nullable: true),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Revenue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    StockValue = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ConsolidatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch_consolidation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_branch_consolidation_branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "branch",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "payroll_run",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    BasicSalary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Hra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Allowances = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PfDeduction = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    EsiDeduction = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TdsDeduction = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetPay = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProcessedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payroll_run", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payroll_run_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "payslip",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BasicSalary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Hra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Allowances = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GrossPay = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PfDeduction = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    EsiDeduction = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NetPay = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PayslipData = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payslip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payslip_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "statutory_deduction",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeductionType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeContribution = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    EmployerContribution = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalDeduction = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "date", nullable: false),
                    Period = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statutory_deduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_statutory_deduction_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "forex_transaction",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReferenceNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    PartyId = table.Column<long>(type: "bigint", nullable: true),
                    PartyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ForeignAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ExchangeRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    InrAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ForexGainLoss = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forex_transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_forex_transaction_currency_exchange_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "currency_exchange",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_forex_transaction_party_directory_PartyId",
                        column: x => x.PartyId,
                        principalTable: "party_directory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gst_entry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InvoiceNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceDate = table.Column<DateTime>(type: "date", nullable: false),
                    PartyId = table.Column<long>(type: "bigint", nullable: true),
                    PartyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TransactionType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PartyGstin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlaceOfSupply = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaxableAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GstRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CgstAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SgstAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IgstAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gst_entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gst_entry_party_directory_PartyId",
                        column: x => x.PartyId,
                        principalTable: "party_directory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "payment_entry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReferenceNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    PaymentMode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PartyId = table.Column<long>(type: "bigint", nullable: true),
                    PartyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BankAccountId = table.Column<long>(type: "bigint", nullable: true),
                    BankAccount = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChequeRefNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payment_entry_bank_account_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "bank_account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_payment_entry_party_directory_PartyId",
                        column: x => x.PartyId,
                        principalTable: "party_directory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "payment_reminder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartyId = table.Column<long>(type: "bigint", nullable: true),
                    PartyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    OverdueBy = table.Column<int>(type: "int", nullable: false),
                    ReminderNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastSent = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_reminder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payment_reminder_party_directory_PartyId",
                        column: x => x.PartyId,
                        principalTable: "party_directory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tds_tcs_entry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Section = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PartyId = table.Column<long>(type: "bigint", nullable: true),
                    PartyName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PanNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TdsRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TdsAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CertificateNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tds_tcs_entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tds_tcs_entry_party_directory_PartyId",
                        column: x => x.PartyId,
                        principalTable: "party_directory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "voucher_entry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VoucherNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VoucherType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VoucherDate = table.Column<DateTime>(type: "date", nullable: false),
                    PartyId = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PaymentMode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BankAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Narration = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voucher_entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_voucher_entry_bank_account_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "bank_account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_voucher_entry_party_directory_PartyId",
                        column: x => x.PartyId,
                        principalTable: "party_directory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stock_item",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StockGroupId = table.Column<long>(type: "bigint", nullable: true),
                    Category = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UnitOfMeasure = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpeningQty = table.Column<int>(type: "int", nullable: false),
                    PurchaseRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    SellingRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ValuationMethod = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    GstRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    HsnSacCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stock_item_stock_group_StockGroupId",
                        column: x => x.StockGroupId,
                        principalTable: "stock_group",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "audit_log",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IpAddress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Module = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Action = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Record = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audit_log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_audit_log_system_user_UserId",
                        column: x => x.UserId,
                        principalTable: "system_user",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "batch_register",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BatchNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturingDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SerialRange = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batch_register", x => x.Id);
                    table.ForeignKey(
                        name: "FK_batch_register_stock_item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "stock_item",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stock_movement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReferenceNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MovementDate = table.Column<DateTime>(type: "date", nullable: false),
                    MovementType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    FromGodownId = table.Column<long>(type: "bigint", nullable: true),
                    ToGodownId = table.Column<long>(type: "bigint", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_movement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stock_movement_godown_FromGodownId",
                        column: x => x.FromGodownId,
                        principalTable: "godown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_stock_movement_godown_ToGodownId",
                        column: x => x.ToGodownId,
                        principalTable: "godown",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_stock_movement_stock_item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "stock_item",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_audit_log_UserId",
                table: "audit_log",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_bank_reconciliation_BankAccountId",
                table: "bank_reconciliation",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_batch_register_ItemId",
                table: "batch_register",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_branch_consolidation_BranchId",
                table: "branch_consolidation",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_forex_transaction_CurrencyId",
                table: "forex_transaction",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_forex_transaction_PartyId",
                table: "forex_transaction",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_gst_entry_PartyId",
                table: "gst_entry",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ledger_account_ParentGroupId",
                table: "ledger_account",
                column: "ParentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_entry_BankAccountId",
                table: "payment_entry",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_entry_PartyId",
                table: "payment_entry",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_reminder_PartyId",
                table: "payment_reminder",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_payroll_run_EmployeeId",
                table: "payroll_run",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_payslip_EmployeeId",
                table: "payslip",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_statutory_deduction_EmployeeId",
                table: "statutory_deduction",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_item_StockGroupId",
                table: "stock_item",
                column: "StockGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_movement_FromGodownId",
                table: "stock_movement",
                column: "FromGodownId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_movement_ItemId",
                table: "stock_movement",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_movement_ToGodownId",
                table: "stock_movement",
                column: "ToGodownId");

            migrationBuilder.CreateIndex(
                name: "IX_tds_tcs_entry_PartyId",
                table: "tds_tcs_entry",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_voucher_entry_BankAccountId",
                table: "voucher_entry",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_voucher_entry_PartyId",
                table: "voucher_entry",
                column: "PartyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "audit_log");

            migrationBuilder.DropTable(
                name: "automation_rule");

            migrationBuilder.DropTable(
                name: "balance_sheet");

            migrationBuilder.DropTable(
                name: "bank_integration");

            migrationBuilder.DropTable(
                name: "bank_reconciliation");

            migrationBuilder.DropTable(
                name: "batch_register");

            migrationBuilder.DropTable(
                name: "branch_consolidation");

            migrationBuilder.DropTable(
                name: "branch_performance");

            migrationBuilder.DropTable(
                name: "budget");

            migrationBuilder.DropTable(
                name: "cash_flow_statement");

            migrationBuilder.DropTable(
                name: "custom_report");

            migrationBuilder.DropTable(
                name: "dashboard_widget");

            migrationBuilder.DropTable(
                name: "forex_transaction");

            migrationBuilder.DropTable(
                name: "gst_entry");

            migrationBuilder.DropTable(
                name: "gst_return");

            migrationBuilder.DropTable(
                name: "ledger_account");

            migrationBuilder.DropTable(
                name: "payment_entry");

            migrationBuilder.DropTable(
                name: "payment_reminder");

            migrationBuilder.DropTable(
                name: "payroll_run");

            migrationBuilder.DropTable(
                name: "payslip");

            migrationBuilder.DropTable(
                name: "profit_loss");

            migrationBuilder.DropTable(
                name: "sales_purchase_summary");

            migrationBuilder.DropTable(
                name: "security_settings");

            migrationBuilder.DropTable(
                name: "statutory_deduction");

            migrationBuilder.DropTable(
                name: "stock_movement");

            migrationBuilder.DropTable(
                name: "stock_report");

            migrationBuilder.DropTable(
                name: "tds_tcs_entry");

            migrationBuilder.DropTable(
                name: "trial_balance");

            migrationBuilder.DropTable(
                name: "vat_service_tax");

            migrationBuilder.DropTable(
                name: "voucher_entry");

            migrationBuilder.DropTable(
                name: "system_user");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "currency_exchange");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "godown");

            migrationBuilder.DropTable(
                name: "stock_item");

            migrationBuilder.DropTable(
                name: "bank_account");

            migrationBuilder.DropTable(
                name: "party_directory");

            migrationBuilder.DropTable(
                name: "stock_group");
        }
    }
}
