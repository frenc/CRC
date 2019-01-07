namespace Exercises.Exercise3.Policies
{
    public interface IDiscontPolicy
    {
        decimal GetDiscount(Product product);
    }
}