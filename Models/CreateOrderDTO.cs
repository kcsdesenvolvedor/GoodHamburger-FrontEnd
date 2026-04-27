namespace GoodHamburger.Web.Models
{
    public class CreateOrderDTO
    {
        public string ClientName { get; set; } = string.Empty;
        public List<OrderItemDTO> OrderItems { get; set; } = new();
    }
}
