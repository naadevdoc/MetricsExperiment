using BasketBusiness;
using BasketBusiness.Model;
using BasketBusiness.Services;
using BasketBusiness.Services.Implementation.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasketBusinessTextsXUnit.Services
{
    public class IBasketServicesTests : IClassFixture<DataFixture>
    {

        [Fact]
        public void This_Is_A_Dummy_Scenario_To_Illustrate_Architecture()
        {
            var sampleAnswerBasketRequest = new SampleAnswerBasketRequest();
            var service = ServiceFactory.GetA<IBasketServices>();
            var sampleAnswerBasketResponse = service.GetSampleResponseService(sampleAnswerBasketRequest);
            Assert.NotNull(service);
            Assert.NotNull(sampleAnswerBasketResponse);
            Assert.True(sampleAnswerBasketResponse.Content == true);
        }
        [Fact]
        public void delta_01_A_persona_can_check_in_a_single_product()
        {
            var basketServices = ServiceFactory.GetA<IBasketServices>();
            var catalogServices = ServiceFactory.GetA<ICatalogueServices>();

            var persona = catalogServices.GetPersona("David");
            Assert.NotNull(persona);
            var clearCartRequest = new ClearCartRequest
            {
                Persona = persona
            };
            var clearCartResponse = basketServices.ClearCart(clearCartRequest);
            Assert.True(clearCartResponse.Ok = true, $"Error on clearing cart: {clearCartResponse.Error}");
            var checkInRequest = new CheckInRequest
            {
                Persona = persona,
                Product = new Product
                {
                    Name = "motion-cam-hero-10-2021",
                },
            };
            CheckInResponse checkInResponse = basketServices.CheckInProduct(checkInRequest);
            Assert.True(checkInResponse.Ok = true, $"Error on check-in product: {checkInResponse.Error}");
            var cartContentRequest = new CartContentRequest
            {
                Persona = persona,
            };
            CartContentResponse cartContentResponse = basketServices.GetCartContent(cartContentRequest);
            Assert.True(cartContentResponse?.Ok);
            Assert.True(cartContentResponse?.Products?.Count == 1);
            Assert.True(cartContentResponse?.Products.Where(x => x.Name == "motion-cam-hero-10-2021").Count() == 1);
            Assert.True(cartContentResponse?.Total == 10.00);
        }
    }
}
