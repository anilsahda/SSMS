namespace SSMS.API.Data.Entitities.SSECommerce
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public decimal Price { get; set; }
        public int TotalQuantity { get; set; }
        public int SellQuantity { get; set; }
        public int SizeId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
