using System.Collections.Generic;
using Refill.Model;

namespace Refill
{
    public class FuelRepositori
    {
        public List<FuelInfo> Get()
        {
            return new List<FuelInfo>()
            {
                new FuelInfo(){Name = "Аи-95", Price = 1100},
                new FuelInfo(){Name = "Аи-92", Price = 9100},
                new FuelInfo(){Name = "ДТ", Price = 7000},
            };
        }

    }
}
