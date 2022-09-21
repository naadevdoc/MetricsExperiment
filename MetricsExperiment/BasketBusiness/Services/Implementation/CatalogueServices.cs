using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation
{
    internal class CatalogueServices : ICatalogueServices
    {
        static List<ExchangeRate> ExchangeRates { get; set; } = new List<ExchangeRate>();
        public void AddOrUpdate(ExchangeRate exchangeRate)
        {
            lock (ExchangeRates)
            {
                ExchangeRates = ExchangeRates.Where(x => x.From != exchangeRate.From && x.To != exchangeRate.To).ToList();
                ExchangeRates.Add(exchangeRate);
            }
        }

        static List<Persona> Personas { get; set; } = new List<Persona>();
        public void AddOrUpdate(Persona persona)
        {
            lock (Personas)
            {
                Personas = Personas.Where(x => x.Name != persona.Name).ToList();
                Personas.Add(persona);
            }
        }

        static List<Product> Products { get; set; } = new List<Product>();
        public void AddOrUpdate(Product product)
        {
            lock (Products)
            {
                Products = Products.Where(x => x.Name != product.Name).ToList();
                Products.Add(product);
            }
        }

        public Product GetProduct(string Name)
        {
            lock (Products)
            {
                return Products.Where(x => x.Name == Name).FirstOrDefault() ?? throw new KeyNotFoundException("Name");
            }
        }

        public Persona GetPersona(string Name)
        {
            lock (Personas)
            {
                return Personas.Where(x => x.Name == Name).FirstOrDefault() ?? throw new KeyNotFoundException("Name");
            }
        }
    }
}
