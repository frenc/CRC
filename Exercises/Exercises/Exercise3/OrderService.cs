using Exercises.Exercise3.Factories;

namespace Exercises.Exercise3
{
    public sealed class OrderService
    {
        private readonly IDiscontPolicyFactory _discontPolicyFactory;

        public OrderService(IDiscontPolicyFactory discontPolicyFactory)
        {
            _discontPolicyFactory = discontPolicyFactory;
        }

        public Order CreateOrder(Client client, Product product)
        {
            var discountPolicy = _discontPolicyFactory.GetPolicy(client);
            var cost = product.Price - discountPolicy.GetDiscount(product);

            return new Order(client.Id, product.Id, cost);
        }
    }
}
