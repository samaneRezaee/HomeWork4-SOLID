

using HomeWork4.Task7_Store_.Interfaces;

namespace HomeWork4.Task7_Store_.Implementations
{
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _amount;
        public FixedAmountDiscount(decimal amount) => _amount = amount;

        public decimal ApplyDiscount(decimal originalPrice) => originalPrice - _amount;
    }
}
