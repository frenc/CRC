using System;

namespace Exercises.Exercise3
{
    public sealed class Order
    {
        public Order(Guid clientId, Guid productId, decimal cost)
        {
            ClientId = clientId;
            ProductId = productId;
            Cost = cost;
        }

        public Guid ClientId { get; }

        public Guid ProductId { get; }

        public decimal Cost { get; }
    }
}