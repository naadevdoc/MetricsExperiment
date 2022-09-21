
namespace BasketBusiness.Model
{
    public class Persona
    {
        public string Name { get; set; } = string.Empty;
        public double FidelityDiscount { get; set; } = 0.0;
        public Currency PreferredCurrency { get; set; } = Currency.EUR;
        public List<Product> ProductsInCart { get; set; } = new List<Product>();
    }
}
