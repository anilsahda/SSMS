namespace SSMS.API.Data.Entitities.SSECommerce
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int PaymentTypeId { get; set; }
        public int BankId { get; set; }
        public int CityId { get; set; }
        public string CardNo { get; set; }
        public string CVV { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}