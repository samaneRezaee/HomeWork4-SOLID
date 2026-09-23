

using HomeWork4.Task7_Store_.Interfaces;

namespace HomeWork4.Task7_Store_.Implementations
{
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage) => _percentage = percentage;
        public decimal ApplyDiscount(decimal price) => price - (price * _percentage / 100);

    }
}
