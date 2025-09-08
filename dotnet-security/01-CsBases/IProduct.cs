using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases
{
    public interface IProduct
    {
        void ApplyDiscount(decimal percentaje);
        string GetDescription();
    }
}
