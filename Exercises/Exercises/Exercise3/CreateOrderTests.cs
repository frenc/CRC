using System;
using Exercises.Exercise3.Factories;
using Exercises.Exercise3.Policies;
using Moq;
using NUnit.Framework;

namespace Exercises.Exercise3
{
    [TestFixture]
    public sealed class CreateOrderTests
    {
        private Client _client;
        private Product _product;

        [SetUp]
        public void SetUp()
        {
            _client = new Client(ClientType.Partner, "Client", "Client", Guid.NewGuid());
            _product = new Product("Product", 1120, Guid.NewGuid());
        }

        [Test]
        public void ShouldCreateOrderWithMoqPolicyFactory()
        {
            // Arrange
            const decimal expectedCost = 1120;

            var policyFactory = new Mock<IDiscontPolicyFactory>();
            policyFactory.Setup(x => x.GetPolicy(It.IsAny<Client>()))
                .Returns(() => new RegularClientDiscontPolicy());

            var orderService = new OrderService(policyFactory.Object);

            // Act
            var order = orderService.CreateOrder(_client, _product);

            // Assert
            Assert.That(order, Is.Not.Null);
            Assert.That(order.ClientId, Is.EqualTo(_client.Id));
            Assert.That(order.ProductId, Is.EqualTo(_product.Id));
            Assert.That(order.Cost, Is.EqualTo(expectedCost));
        }

        [Test]
        public void ShouldCreateOrderWithFakePolicyFactory()
        {
            // Arrange
            const decimal expectedCost = 1120;

            var policyFactory = new FakePolicyFactory();
            var orderService = new OrderService(policyFactory);

            // Act
            var order = orderService.CreateOrder(_client, _product);

            // Assert
            Assert.That(order, Is.Not.Null);
            Assert.That(order.ClientId, Is.EqualTo(_client.Id));
            Assert.That(order.ProductId, Is.EqualTo(_product.Id));
            Assert.That(order.Cost, Is.EqualTo(expectedCost));
        }
    }

    public sealed class FakePolicyFactory : IDiscontPolicyFactory
    {
        public IDiscontPolicy GetPolicy(Client client)
        {
            return new RegularClientDiscontPolicy();
        }
    }
}
