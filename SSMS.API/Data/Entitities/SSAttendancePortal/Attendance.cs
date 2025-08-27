namespace SSMS.API.Data.Entitities.SSAttendancePortal
{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int StandardId { get; set; }
        public int DivisionId { get; set; }
        public string RollNumber { get; set; }
        public int AttendanceTypeId { get; set; } //Present, Absent, Leave
        public DateTime AttendanceDate { get; set; }
        public int AttendanceBy { get; set; }
    }
}