using BasketBusiness;
using BasketBusiness.Model;
using BasketBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusinessTextsXUnit
{
    public class DataFixture : IDisposable
    {
        public DataFixture()
        {
            var catalogServices = ServiceFactory.GetA<ICatalogueServices>();
            catalogServices.AddOrUpdate(new Product { Name = "motion-cam-hero-09-2019", Price = 10, Currency = Currency.EUR, Discount = 0.1 });
            catalogServices.AddOrUpdate(new Product { Name = "motion-cam-hero-10-2021", Price = 10, Currency = Currency.EUR, Discount = 0.0 });
            catalogServices.AddOrUpdate(new Product { Name = "phone-hero-13-2022", Price = 1342, Currency = Currency.EUR, Discount = 0.0 });
            catalogServices.AddOrUpdate(new Product { Name = "phone-hero-12-2019", Price = 999, Currency = Currency.EUR, Discount = 0.05 });
            catalogServices.AddOrUpdate(new Persona { Name = "David", FidelityDiscount = 0.0, PreferredCurrency = Currency.EUR });
            catalogServices.AddOrUpdate(new Persona { Name = "Maria", FidelityDiscount = 0.2, PreferredCurrency = Currency.EUR });
            catalogServices.AddOrUpdate(new Persona { Name = "Paul", FidelityDiscount = 0.0, PreferredCurrency = Currency.USD });
            catalogServices.AddOrUpdate(new Persona { Name = "Oshiro", FidelityDiscount = 0.1, PreferredCurrency = Currency.JPY });
            catalogServices.AddOrUpdate(new Persona { Name = "Jules", FidelityDiscount = 0.05, PreferredCurrency = Currency.JPY });
            catalogServices.AddOrUpdate(new ExchangeRate { From = Currency.EUR, To = Currency.USD, Rate = 1.134 });
            catalogServices.AddOrUpdate(new ExchangeRate { From = Currency.USD, To = Currency.EUR, Rate = 0.881 });
            catalogServices.AddOrUpdate(new ExchangeRate { From = Currency.USD, To = Currency.JPY, Rate = 114.386 });
            catalogServices.AddOrUpdate(new ExchangeRate { From = Currency.JPY, To = Currency.USD, Rate = 0.009 });
            catalogServices.AddOrUpdate(new ExchangeRate { From = Currency.JPY, To = Currency.EUR, Rate = 0.008 });
            catalogServices.AddOrUpdate(new ExchangeRate { From = Currency.EUR, To = Currency.JPY, Rate = 129.737 });
        }

        public void Dispose()
        {

        }
    }
}
