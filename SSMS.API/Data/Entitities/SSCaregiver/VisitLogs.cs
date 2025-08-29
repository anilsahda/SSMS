namespace SSMS.API.Data.Entitities.SSCaregiver
{
    public class VisitLogs
    {
        public int Id { get; set; } //(PK)
        public int ScheduleId { get; set; } //(FK → Schedule)
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int CreatedBy { get; set; }
    }
}



//6. Billing & Payments
//Invoices
//InvoiceId (PK)
//PatientId (FK → Patients)
//GeneratedDate
//DueDate
//TotalAmount
//Status (Paid, Pending, Overdue)

//InvoiceItems
//InvoiceItemId (PK)
//InvoiceId (FK → Invoices)
//Description
//Quantity
//UnitPrice
//Amount

//Payments
//PaymentId (PK)
//InvoiceId (FK → Invoices)
//PaymentDate
//PaymentMethod (Card, Cash, Insurance, Online)
//AmountPaid
//TransactionReference

//7. Compliance & Auditing
//AuditLogs
//AuditId (PK)
//UserId (FK → Users)
//Action (Created, Updated, Deleted, Login, Logout)
//Entity (Caregiver, Patient, Invoice, etc.)
//EntityId
//Timestamp
//IPAddress

//Incidents
//IncidentId (PK)
//PatientId (FK → Patients)
//CaregiverId (FK → Caregivers)
//Date
//Description
//ReportedBy (FK → Users)
//ActionTaken

//8. System & Config
//Settings
//SettingId (PK)
//Key
//Value
//Notifications
//NotificationId (PK)
//UserId (FK → Users)
//Message
//Type (Email, SMS, In-App)
//Status (Unread, Read)
//CreatedAt