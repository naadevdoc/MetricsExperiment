using BasketBusiness.Services.Implementation.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation
{
    internal class BasketServices : IBasketServices
    {
        private ICatalogueServices catalogueServices = ServiceFactory.GetA<ICatalogueServices>();
        public CheckInResponse CheckInProduct(CheckInRequest checkInRequest)
        {
            var checkInResponse = new CheckInResponse();
            var persona = catalogueServices.GetPersona(checkInRequest.Persona.Name);
            var product = catalogueServices.GetProduct(checkInRequest.Product.Name);
            persona.ProductsInCart.Add(product);
            return checkInResponse;
        }

        public ClearCartResponse ClearCart(ClearCartRequest clearCartRequest) => new ClearCartResponse();

        public CartContentResponse GetCartContent(CartContentRequest cartContentRequest)
        {
            var cartContentResponse = new CartContentResponse();
            var persona = catalogueServices.GetPersona(cartContentRequest.Persona.Name);
            cartContentResponse.Total = persona.ProductsInCart.Sum(x => x.Price);
            cartContentResponse.Products = persona.ProductsInCart;
            return cartContentResponse;
        }

        public SampleAnswerBasketResponse GetSampleResponseService(SampleAnswerBasketRequest? basketRequest)
        {
            return new SampleAnswerBasketResponse { Content = true };
        }
    }
}
