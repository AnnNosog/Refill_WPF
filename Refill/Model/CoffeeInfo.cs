
namespace Refill.Model
{
    public class CoffeeInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal SumPrice { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
