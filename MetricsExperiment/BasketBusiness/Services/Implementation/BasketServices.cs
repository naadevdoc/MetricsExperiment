using BasketBusiness.Services.Implementation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation
{
    internal class BasketServices : IBasketServices
    {
        public SampleAnswerBasketResponse GetSampleResponseService(SampleAnswerBasketRequest? basketRequest)
        {
            return new SampleAnswerBasketResponse { Content = true };
        }
    }
}
