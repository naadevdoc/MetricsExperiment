using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation.Poco
{
    public class CheckInRequest : BasketRequest
    {
        public Persona Persona { get; set; } = new Persona();
        public Product Product { get; set; } = new Product();
    }
}
