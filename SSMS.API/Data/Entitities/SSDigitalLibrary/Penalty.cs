namespace SSMS.API.Data.Entitities.SSDigitalLibrary
{
    public class Penalty
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BranchId { get; set; }
        public int StudentId { get; set; }
        public int PenaltyDays { get; set; }
        public decimal PenaltyAmount { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}