using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task7_Store_.Interfaces
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal originalPrice);
    }
}
