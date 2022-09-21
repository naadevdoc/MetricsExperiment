using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation.Poco
{
    public class CartContentResponse : BasketResponse
    {
        public IList<Product> Products { get; set; } = new List<Product>();
        public double Total { get; set; }
    }
}
