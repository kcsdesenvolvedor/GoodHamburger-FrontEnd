namespace GoodHamburger.Web.Models
{
    public class OrderItemDTO
    {
        public int Type { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}
