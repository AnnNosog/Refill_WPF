﻿namespace Refill
{
    public class FuelInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}