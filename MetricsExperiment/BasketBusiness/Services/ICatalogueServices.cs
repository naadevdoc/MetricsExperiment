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
        void AddProduct(Product product);
        void AddPersona(Persona persona);
        void AddExchangeRate(ExchangeRate exchangeRate);
    }
}
