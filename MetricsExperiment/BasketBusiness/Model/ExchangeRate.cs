using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Model
{
    public class ExchangeRate
    {
        public Currency From { get; set; }
        public Currency To { get; set; }
        public double Rate { get; set; }
    }
}
