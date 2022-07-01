using BasketBusiness;
using BasketBusiness.Services;
using BasketBusiness.Services.Implementation.Model;

namespace BasketBusinessTestsGherkin.StepDefinitions
{
    [Binding]
    public sealed class BasketStepDefinitions
    {
        private SampleAnswerBasketRequest? sampleAnswerBasketRequest;
        private SampleAnswerBasketResponse? sampleAnswerBasketResponse;

        [Given(@"I create a sample answer request")]
        public void GivenICreateASampleAnswerRequest()
        {            
            sampleAnswerBasketRequest = new SampleAnswerBasketRequest();
        }

        [When(@"I request the request to the service")]
        public void WhenIRequestToService()
        {
            sampleAnswerBasketResponse = ServiceFactory.GetA<IBasketServices>().GetSampleResponseService(sampleAnswerBasketRequest);
        }
        [Then(@"the content of sample answer response will be '([^']*)'")]
        public void ThenTheContentOfSampleAnswerResponseWillBe(bool trueOrFalse)
        {
            Assert.True(sampleAnswerBasketResponse?.Content == trueOrFalse,"Content shall be true");
        }


    }
}