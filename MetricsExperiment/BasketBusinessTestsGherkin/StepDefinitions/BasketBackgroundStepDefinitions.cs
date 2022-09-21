using BasketBusiness.Model;
using BasketBusiness.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketBusiness;
using BasketBusiness.Services;

namespace BasketBusinessTestsGherkin.StepDefinitions
{
    [Binding]
    public class BasketBackgroundStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public BasketBackgroundStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        /*
         
      | product                 | price | currency | discount |
	  | motion-cam-hero-09-2019 | 10    | EUR      | 10%      |
	  | motion-cam-hero-10-2021 | 10    | EUR      | 0%       |
	  | phone-hero-13-2022      | 1342  | EUR      | 0%       |
	  | phone-hero-12-2019      | 999   | EUR      | 5%       |
         
         */
        [Given(@"the catalogue has following products")]
        public void GivenTheCatalogueHasFollowingProducts(Table productsTable)
        {
            var catalogueServices = ServiceFactory.GetA<ICatalogueServices>();
            foreach (var productRow in productsTable.Rows)
            {
                var product = new Product
                {
                    Name = productRow["product"],
                    Price = productRow["price"].ToDouble(),
                    Currency = productRow["currency"].ToCurrency(),
                    Discount = productRow["discount"].FromPercentageStringToDouble()
                };
                catalogueServices.AddOrUpdate(product);
            }

        }
        /*
      | Name        | Fidelity discount | Preferred currency |
	  | David       | 0%                | EUR                |
	  | Maria       | 20%               | EUR                |
	  | Paul        | 0%                | USD                |
	  | Oshiro      | 10%               | JPY                |
	  | Jules       | 5%                | JPY                |
         */
        [Given(@"these personas are registered")]
        public void GivenThesePersonasAreRegistered(Table personasTable)
        {
            var catalogueServices = ServiceFactory.GetA<ICatalogueServices>();
            foreach (var personaRow in personasTable.Rows)
            {
                var persona = new Persona
                {
                    Name = personaRow["Name"],
                    FidelityDiscount = personaRow["Fidelity discount"].FromPercentageStringToDouble(),
                    PreferredCurrency = personaRow["Preferred currency"].ToCurrency()
                };
                catalogueServices.AddOrUpdate(persona);
            }
        }
        /*         
	  | From Currency | To Currency | Rate    |
	  | EUR           | USD         | 1.134   |
	  | USD           | EUR         | 0.881   |
	  | USD           | JPY         | 114.386 |
	  | JPY           | USD         | 0.009   |
	  | JPY           | EUR         | 0.008   |
	  | EUR           | JPY         | 129.737 |
         */
        [Given(@"the exchange rate at the time of operation is as follows")]
        public void GivenTheExchangeRateAtTheTimeOfOperationIsAsFollows(Table exchangeTable)
        {
            var catalogueServices = ServiceFactory.GetA<ICatalogueServices>();
            foreach (var exchangeRow in exchangeTable.Rows)
            {
                var exchangeRate = new ExchangeRate
                {
                    From = exchangeRow["From Currency"].ToCurrency(),
                    To = exchangeRow["From Currency"].ToCurrency(),
                    Rate = exchangeRow["Rate"].ToDouble()
                };
                catalogueServices.AddOrUpdate(exchangeRate);
            }
        }
    }
}
