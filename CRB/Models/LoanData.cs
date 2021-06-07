namespace CRB.Models
{
    public class LoanData
    {
        public long OurBranchID { get; set; }
        public long AccountID { get; set; }
        public long LoanSeries { get; set; }
        public long LoanRefNo { get; set; }
        public long ApplicationID { get; set; }
        public long SanctionBy { get; set; }
        public string SanctionDate { get; set; }
        public double SanctionAmount { get; set; }
        public double LoanAmount { get; set; }
        public double BookedAmount { get; set; }
        public string ValueDate { get; set; }
        public int NumberOfDisbursements { get; set; }
        public string DisbursementModelID { get; set; }
        public double DisbursementAmount { get; set; }
        public string DisbursedBy { get; set; }
        public int Term { get; set; }
        public string LoanPeriodID { get; set; }
        public int RepaymentTerm { get; set; }
        public double InterestRate { get; set; }
    }
}