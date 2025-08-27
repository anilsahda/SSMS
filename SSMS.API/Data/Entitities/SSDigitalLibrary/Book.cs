namespace SSMS.API.Data.Entitities.SSDigitalLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int PublicationId { get; set; }
        public int BranchId { get; set; }
        public decimal Price { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int RentQuantity { get; set; }
        public string Image { get; set; }
    }
}
