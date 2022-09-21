using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services
{
    public interface ICatalogueServices
    {
        void AddOrUpdate(Product product);
        Product GetProduct(string Name);
        void AddOrUpdate(Persona persona);
        Persona GetPersona(string Name);
        void AddOrUpdate(ExchangeRate exchangeRate);
    }
}
