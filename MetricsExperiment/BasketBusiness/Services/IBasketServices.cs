using BasketBusiness.Services.Implementation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services
{
    public interface IBasketServices
    {
        SampleAnswerBasketResponse GetSampleResponseService(SampleAnswerBasketRequest? basketRequest);
    }
}
