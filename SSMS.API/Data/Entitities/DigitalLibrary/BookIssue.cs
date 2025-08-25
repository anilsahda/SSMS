namespace SSMS.API.Data.Entitities.DigitalLibrary
{
    public class BookIssue
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BranchId { get; set; }
        public int StudentId { get; set; }
        public int Days { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}