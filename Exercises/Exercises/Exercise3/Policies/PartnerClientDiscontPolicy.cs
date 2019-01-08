
namespace Exercises.Exercise3.Policies
{
    public sealed class  PartnerClientDiscontPolicy : IDiscontPolicy
    {
        private const decimal DiscountPercent = 50;

        public decimal GetDiscount(Product product)
        {
            return product.Price * DiscountPercent / 100;
        }
    }
}