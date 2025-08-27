namespace SSMS.API.Data.Entitities.SSAttendancePortal
{
    public class AttendancePortalStudentProfile
    {
        public int Id { get; set; }
        public int StandardId { get; set; }
        public int DivisionId { get; set; }
        public int Seat { get; set; }
        public string RollNumber { get; set; }
    }
}