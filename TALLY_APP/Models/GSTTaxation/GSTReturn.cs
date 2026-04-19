using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using TALLY_APP.Models.AccountingFinance;
using TALLY_APP.Models.InventoryManagement;
using TALLY_APP.Models.GSTTaxation;
using TALLY_APP.Models.PayrollManagement;
using TALLY_APP.Models.BankingPayments;
using TALLY_APP.Models.ReportingAnalytics;
using TALLY_APP.Models.MultiLocationBranch;
using TALLY_APP.Models.RemoteAccessSecurity;
using TALLY_APP.Models.AdditionalFeatures;
namespace TALLY_APP.Models.GSTTaxation
{
/**
 * =====================================================
 * ENTITY: GSTReturn
 * TABLE: gst_return
 * MODULE: GSTTaxation
 * =====================================================
 *
 * Auto-generated EF Core Entity Model
 * Includes:
 * - Column mappings
 * - Data annotations
 * - Relationships
 *
 * Generated: 2026-04-17 21:45:32
 */

    [Table("gst_return")]
    public class GSTReturn
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: ReturnType
     * Type: string
     */
    [Column("ReturnType")]
    [Required]
    [MaxLength(50)]
    public string ReturnType { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

    /**
     * Column: DueDate
     * Type: DateTime
     */
    [Column("DueDate", TypeName = "date")]
    public DateTime DueDate { get; set; }

    /**
     * Column: TotalOutward
     * Type: decimal
     */
    [Column("TotalOutward")]
    public decimal TotalOutward { get; set; }

    /**
     * Column: TaxCollected
     * Type: decimal
     */
    [Column("TaxCollected")]
    public decimal TaxCollected { get; set; }

    /**
     * Column: TotalInward
     * Type: decimal
     */
    [Column("TotalInward")]
    public decimal TotalInward { get; set; }

    /**
     * Column: ItcAvailable
     * Type: decimal
     */
    [Column("ItcAvailable")]
    public decimal ItcAvailable { get; set; }

    /**
     * Column: NetPayable
     * Type: decimal
     */
    [Column("NetPayable")]
    public decimal NetPayable { get; set; }

    /**
     * Column: Status
     * Type: string
     */
    [Column("Status")]
    [Required]
    [MaxLength(20)]
    public string Status { get; set; }

    /**
     * Column: FiledDate
     * Type: DateTime
     */
    [Column("FiledDate", TypeName = "datetime")]
    public DateTime FiledDate { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}



