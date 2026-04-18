using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Description1 { get; set; } = string.Empty;
        public string Description2 { get; set; } = string.Empty;
        public string Description3 { get; set; } = string.Empty;
        public string Description4 { get; set; } = string.Empty;
        public string MapInfo { get; set; } = string.Empty;
    }
}
