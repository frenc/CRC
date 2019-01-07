using System;

namespace Exercises.Exercise3
{
    public sealed class Product
    {
        public Product(string name, decimal price, Guid id)
        {
            Name = name;
            Price = price;
            Id = id;
        }

        public Guid Id { get; }

        public string Name { get; }

        public decimal Price { get; }
    }
}