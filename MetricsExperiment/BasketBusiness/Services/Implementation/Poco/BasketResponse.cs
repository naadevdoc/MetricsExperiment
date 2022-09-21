﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBusiness.Services.Implementation.Poco
{
    public class BasketResponse
    {
        public bool Ok { get; set; } = true;
        public string Error { get; set; } = string.Empty;
    }
}
