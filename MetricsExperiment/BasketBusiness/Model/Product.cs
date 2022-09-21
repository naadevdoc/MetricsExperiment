
namespace BasketBusiness.Model
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public double Discount { get; set; }
    }
}
