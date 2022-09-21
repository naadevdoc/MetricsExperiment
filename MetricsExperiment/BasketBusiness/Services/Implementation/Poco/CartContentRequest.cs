using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation.Poco
{
    public class CartContentRequest : BasketRequest
    {
        public Persona Persona { get; set; } = new Persona();
    }
}
