using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation.Poco
{
    public class CheckInResponse : BasketResponse
    {
        public Product Product { get; internal set; } = new Product();
    }
}
