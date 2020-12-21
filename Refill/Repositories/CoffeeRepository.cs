using Refill.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Refill.Repositories
{
    class CoffeeRepository    
    {
        private List<CoffeeInfo> _coffeeInfo;

        public CoffeeRepository()
        {
            _coffeeInfo = new List<CoffeeInfo>()
            {
                new CoffeeInfo(){Name = "Хот-Дог", Price = 500, SumPrice = 0, Quantity = 0},
                new CoffeeInfo(){Name = "Гамбургер", Price = 1000, SumPrice = 0, Quantity = 0},
                new CoffeeInfo(){Name = "Гизбургер", Price = 1200, SumPrice = 0, Quantity = 0},
                new CoffeeInfo(){Name = "Coca-Cola", Price = 300, SumPrice = 0, Quantity = 0}
            };
        }
        public List<CoffeeInfo> Get()
        {
            return _coffeeInfo;
        }

    }
}