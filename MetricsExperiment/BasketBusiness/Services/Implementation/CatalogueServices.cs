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
        public void AddExchangeRate(ExchangeRate exchangeRate)
        {
            lock(ExchangeRates)
            {
                ExchangeRates = ExchangeRates.Where(x => x.From != exchangeRate.From && x.To != exchangeRate.To).ToList();
                ExchangeRates.Add(exchangeRate);
            }
        }

        static List<Persona> Personas { get; set; } = new List<Persona>();
        public void AddPersona(Persona persona)
        {
            lock(Personas)
            {
                Personas = Personas.Where(x => x.Name != persona.Name).ToList();
                Personas.Add(persona);
            }
        }

        static List<Product> Products { get; set; } = new List<Product>();
        public void AddProduct(Product product)
        {
            lock(Products)
            {
                Products = Products.Where(x => x.Name != product.Name).ToList();
                Products.Add(product);
            }
        }
    }
}
