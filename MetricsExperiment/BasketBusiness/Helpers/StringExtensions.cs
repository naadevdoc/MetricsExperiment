using BasketBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Helpers
{
    public static class StringExtensions
    {
        public static double ToDouble(this string value)
        {
            return double.TryParse(value, out double result) ? result : throw new FormatException($"{value} is not a double");
        }
        public static Currency ToCurrency(this string value)
        {
            return Enum.TryParse<Currency>(value, out Currency currency) ? currency : throw new FormatException($"{value} is not a recognized currency");
        }

        public static double FromPercentageStringToDouble(this string value)
        {
            return double.TryParse(value.Replace("%", ""),out double result) ? result / 100 : throw new FormatException($"{value} could not be converted to percentage");
        }
    }
}
