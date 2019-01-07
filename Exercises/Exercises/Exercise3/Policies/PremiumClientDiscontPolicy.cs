namespace Exercises.Exercise3.Policies
{
    public sealed class PremiumClientDiscontPolicy : IDiscontPolicy
    {
        private const decimal DiscountPercent = 30;

        public decimal GetDiscount(Product product)
        {
            return product.Price * DiscountPercent / 100;
        }
    }
}