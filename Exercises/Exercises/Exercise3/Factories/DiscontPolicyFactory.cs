using System.ComponentModel;
using Exercises.Exercise3.Policies;

namespace Exercises.Exercise3.Factories
{
    public sealed class DiscontPolicyFactory : IDiscontPolicyFactory
    {
        public IDiscontPolicy GetPolicy(Client client)
        {
            switch (client.ClientType)
            {
                case ClientType.Regular:
                    return new RegularClientDiscontPolicy();
                case ClientType.Partner:
                    return new PartnerClientDiscontPolicy();
                case ClientType.Premium:
                    return new PremiumClientDiscontPolicy();
            }

            throw new InvalidEnumArgumentException();
        }
    }
}