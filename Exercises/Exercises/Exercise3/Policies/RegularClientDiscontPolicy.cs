namespace Exercises.Exercise3.Policies
{
    public sealed class RegularClientDiscontPolicy : IDiscontPolicy
    {
        public decimal GetDiscount(Product product)
        {
            return 0;
        }
    }
}