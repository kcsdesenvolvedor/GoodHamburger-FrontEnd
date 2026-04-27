namespace GoodHamburger.Web.Models
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public List<MenuItemDTO> Items { get; set; }
        public decimal Subtotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
    }
}
