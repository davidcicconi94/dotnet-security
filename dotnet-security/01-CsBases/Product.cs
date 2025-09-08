using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public bool isAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UniqueCode { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            CreatedAt = DateTime.Now;
            UniqueCode = Guid.NewGuid();
        }

        public void ApplyDiscount(decimal percentaje)
        {
            var discountAmount = Price * (percentaje / 100);
            Price -= discountAmount; // Price = Price - discountAmount;
        }

        public string GetDescription()
        {
            return $"{Name} - ${Price}";
        }
    }
}
