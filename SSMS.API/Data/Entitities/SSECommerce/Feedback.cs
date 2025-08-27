namespace SSMS.API.Data.Entitities.SSECommerce
{
    public class Feedback
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public int StarRating { get; set; }
        public DateTime Date { get; set; }
    }
}