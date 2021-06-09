using System;
using System.ComponentModel.DataAnnotations;

namespace CRB.Models
{
    public class LoanDataModel
    {
        [Required]
        [Display(Name = "OurBranchID")]
        public string OurBranchID { get; set; }

        [Display(Name = "AccountID")]
        public string AccountID { get; set; }

        [Display(Name = "LoanSeries")]
        public int? LoanSeries { get; set; }

        [Display(Name = "LoanRefNo")]
        public string LoanRefNo { get; set; }

        [Display(Name = "ApplicationID")]
        public string ApplicationID { get; set; }

        [Display(Name = "SanctionBy")]
        public string SanctionBy { get; set; }

        [Display(Name = "SanctionDate")]
        public string SanctionDate { get; set; }

        [Display(Name = "SanctionAmount")]
        public decimal? SanctionAmount { get; set; }

        [Display(Name = "LoanAmount")]
        public decimal? LoanAmount { get; set; }

        [Display(Name = "BookedAmount")]
        public decimal? BookedAmount { get; set; }

        [Display(Name = "ValueDate")]
        public DateTime? ValueDate { get; set; }

        [Display(Name = "NumberOfDisbursements")]
        public int? NumberOfDisbursements { get; set; }

        [Display(Name = "DisbursementModelID")]
        public string DisbursementModelID { get; set; }

        [Display(Name = "DisbursementAmount")]
        public decimal? DisbursementAmount { get; set; }

        [Display(Name = "DisbursedBy")]
        public string DisbursedBy { get; set; }

        [Display(Name = "Term")]
        public int? Term { get; set; }

        [Display(Name = "LoanPeriodID")]
        public string LoanPeriodID { get; set; }

        [Display(Name = "RepaymentTerm")]
        public int? RepaymentTerm { get; set; }

        [Display(Name = "InterestRate")]
        public float? InterestRate { get; set; }

        [Display(Name = "InstallmentStartDate")]
        public string InstallmentStartDate { get; set; }

        [Display(Name = "MaturityDate")]
        public DateTime? MaturityDate { get; set; }

        [Display(Name = "InstallmentAmount")]
        public decimal? InstallmentAmount { get; set; }

        [Display(Name = "CreditOfficerID")]
        public string CreditOfficerID { get; set; }

        [Display(Name = "OutstandingPrincipal")]
        public decimal? OutstandingPrincipal { get; set; }

        [Display(Name = "InterestAmount")]
        public decimal? InterestAmount { get; set; }
    }

    public static class DbConn
    {
        public static string ConnectionString { get; set; }
    }
}