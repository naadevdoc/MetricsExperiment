using BasketBusiness;
using BasketBusiness.Services;
using BasketBusiness.Services.Implementation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasketBusinessTextsXUnit.Services
{
    public class IBasketServicesTests
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
    }
}
