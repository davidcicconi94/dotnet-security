using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.Services
{
    public class ProductService : Product
    {
        public int DurationInDays { get; set; }
        public ProductService(string name, decimal price, int duration) : base(name, price)
        {
            DurationInDays = duration;
        }

        public override string GetDescription()
        {
            return "" + base.GetDescription() + $" - Duration: {DurationInDays} days";
        }
    }
}
