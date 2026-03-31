using System;
using System.Collections.Generic;
using System.Text;

namespace ProductClientHub.Communication.Requests
{
    public class RequestProductJson
    {
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
