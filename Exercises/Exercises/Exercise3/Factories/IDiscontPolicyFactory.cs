using Exercises.Exercise3.Policies;

namespace Exercises.Exercise3.Factories
{
    public interface IDiscontPolicyFactory
    {
        IDiscontPolicy GetPolicy(Client client);
    }
}